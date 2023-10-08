using GuestBookingSystem.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuestBookingSystem.Business;
using GuestBookingSystem.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;


namespace GuestBookingSystem.Presentation
{
    public partial class MakeBookingForm : Form
    {
        #region Data Members
        private Booking booking = new Booking();
        private BookingController bookingController = new BookingController();

        private bool isOpen = false;
        string[] numbersCheck = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private string currentState = "Existing Customer";

        #endregion

        #region Property Methods
        public bool IsOpen
        {
            set { isOpen = value; }
            get { return isOpen; }
        }

        #endregion 

        #region Constructor

        public MakeBookingForm()
        {
            InitializeComponent();
            this.isOpen = true;
        }

        public MakeBookingForm(String CustomerID, DateTime dateA, DateTime dateD)
        {
            InitializeComponent();
            this.isOpen = true;
            txtCustID.Text = CustomerID;
            currentState = "Existing Customer";
            dateTimePickerArrival.Value = dateA;
            dateTimePickerDepartureDate.Value = dateD;
            UpdateControlVisibility();
        }

        public MakeBookingForm(DateTime date1, DateTime date2)
        {
            InitializeComponent();
            this.isOpen = true;
            this.dateTimePickerArrival.Value = date1;
            this.dateTimePickerDepartureDate.Value = date2;
            currentState = "Existing Customer";
            UpdateControlVisibility();
        }

        #endregion

        #region Utility Methods
        private string generateRef()
        {
            string custStart = txtCustID.ToString().Substring(0, 3);
            string cardNum = txtCardNum.ToString().Substring(0, 2);

            return custStart + cardNum;
        }
        private void PopulateObject()
        {
            booking.BookingID = bookingController.getUniqueBookingID();
            booking.CustomerID = txtCustID.Text;
            booking.ArriveDate = dateTimePickerArrival.Value;
            booking.LeaveDate = dateTimePickerDepartureDate.Value;
            booking.RoomNumber = bookingController.getFirstAvailableRoom(dateTimePickerArrival.Value, dateTimePickerDepartureDate.Value);
            booking.CardNumber = txtCardNum.Text;
            booking.setDeposit();
            booking.setPricePerNight();
            booking.setTotalPrice();

        }

        private void ClearAll()
        {
            txtCustID.Text = "";
            txtCardNum.Text = "";
            dateTimePickerArrival.Value = DateTime.Today;
            dateTimePickerDepartureDate.Value = DateTime.Today;
        }

        private void UpdateControlVisibility()
        {
            // Update control visibility based on the current state.
            if (currentState == "New Customer")
            {
                lblCustID.Visible = false;
                txtCustID.Visible = false;
                txtCardNum.Visible = false;
                lblADate.Visible = false;
                lblLeaveDate.Visible = false;
                dateTimePickerArrival.Visible = false;
                dateTimePickerDepartureDate.Visible = false;
                label2.Visible = false;
                rBtnNewCustomer.Checked = true;
            }
            else if (currentState == "Existing Customer")
            {
                lblCustID.Visible = true;
                txtCustID.Visible = true;
                rBtnExistingCustomer.Checked = true;
                txtCardNum.Visible = true;
                lblADate.Visible = true;
                lblLeaveDate.Visible = true;
                dateTimePickerArrival.Visible = true;
                dateTimePickerDepartureDate.Visible = true;
                label2.Visible = true;
            }
        }

        private bool checkNumbers(String value)
        {

            // Define a regular expression pattern for a 16-digit number
            string pattern = @"^\d{16}$";

            // Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            // Check if the TextBox's text matches the pattern
            if (regex.IsMatch(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Form Events
        private void MakeBookingForm_Activated(object sender, EventArgs e)
        {
            currentState = "Existing Customer";
            UpdateControlVisibility();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCustID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool checkCard = checkNumbers(txtCardNum.Text);

            if (currentState == "New Customer")
            {

                //open create customer form
                this.Close();
                CustomerController customerController = new CustomerController();
                CreateCustomerForm createCustomerForm = new CreateCustomerForm(customerController, dateTimePickerArrival.Value, dateTimePickerDepartureDate.Value);
                createCustomerForm.MdiParent = this.MdiParent;
                createCustomerForm.Show();

            }
            else if (currentState == "Existing Customer")
            {
                if (txtCustID.Text.Equals("") || txtCustID.TextLength != 13)
                {
                    MessageBox.Show("Please enter a valid CustomerID");
                }
                else if (this.dateTimePickerDepartureDate.Value < this.dateTimePickerArrival.Value)
                {
                    MessageBox.Show("Cannot choose a departure date that is before the arrival date");
                }

                else
                if (txtCardNum.Text.Equals("") || checkCard == false)
                {
                    MessageBox.Show("Please enter a valid Card Number");
                }
                else
                {
                    //add booking to DB
                    PopulateObject();
                    bookingController.DataMaintanence(booking, Data.DB.DBOperation.Add);
                    bookingController.FinalizeChanges(booking);
                    MessageBox.Show("Booking entered!");
                    string referenceNum = generateRef();
                    Payment paymentForm = new Payment(booking.BookingID, booking.ArriveDate, booking.LeaveDate);
                    paymentForm.Show();
                    
                    this.Close();
                    MessageBox.Show("Please ask the customer if they will make a deposit payment now or at a later date.");
                    ClearAll();

                }
            }
        }

        private void MakeBookingForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            currentState = "Existing Customer";
            UpdateControlVisibility();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void MakeBookingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rBtnNewCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnNewCustomer.Checked)
            {
                currentState = "New Customer";
                UpdateControlVisibility();
            }
        }

        private void rBtnExistingCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnExistingCustomer.Checked)
            {
                currentState = "Existing Customer";
                UpdateControlVisibility();
            }
        }
    }

    #endregion
}
