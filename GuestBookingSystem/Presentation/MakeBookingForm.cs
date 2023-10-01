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


namespace GuestBookingSystem.Presentation
{
    public partial class MakeBookingForm : Form
    {


        #region Data Members
        private Booking booking = new Booking();
        private BookingController bookingController = new BookingController();

        private bool isOpen = false;
        private string currentState = "New Customer";

        #endregion

        #region Property Members
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

        private void MakeBookingForm_Activated(object sender, EventArgs e)
        {
            currentState = "New Customer";
            UpdateControlVisibility();
        }

        #endregion

        #region Utility Methods


        private void PopulateObject()
        {
            booking.BookingID = bookingController.getUniqueBookingID();
            booking.CustomerID = txtCustID.Text;
            booking.ArriveDate = dateTimePickerArrival.Value;
            booking.LeaveDate = dateTimePickerDepartureDate.Value;
            booking.RoomNumber = bookingController.getFirstAvailableRoom(dateTimePickerArrival.Value, dateTimePickerDepartureDate.Value);
            booking.CardNumber = txtCardNum.Text;

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
                rBtnNewCustomer.Checked = true;
            }
            else if (currentState == "Existing Customer")
            {
                lblCustID.Visible = true;
                txtCustID.Visible = true;
            }
        }

        #endregion

        #region Form Events


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCustID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (this.dateTimePickerDepartureDate.Value < this.dateTimePickerArrival.Value)
            {
                MessageBox.Show("Cannot choose a departure date that is before the arrival date");
            }
            else
            {
                if (currentState == "New Customer")
                {
                    //open create customer form
                    this.Close();
                    CustomerController customerController = new CustomerController();
                    CreateCustomerForm createCustomerForm = new CreateCustomerForm(customerController);
                    createCustomerForm.MdiParent = this.MdiParent;
                    createCustomerForm.Show();

                }
                else if (currentState == "Existing Customer")
                {
                    if (txtCustID.Text.Equals("") || txtCustID.TextLength != 3)
                    {
                        MessageBox.Show("Please enter a valid CustomerID");
                    }
                    else
                    {
                        //add booking to DB
                        PopulateObject();
                        bookingController.DataMaintanence(booking, Data.DB.DBOperation.Add);
                        bookingController.FinalizeChanges(booking);
                        MessageBox.Show("Booking entered!");
                        ClearAll();

                    }
                }
            }
        }

        private void MakeBookingForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            currentState = "New Customer";
            UpdateControlVisibility();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            ClearAll();
        }


        #endregion

        private void MakeBookingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCardNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {

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
}
