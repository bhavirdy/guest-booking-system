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

namespace GuestBookingSystem.Presentation
{
    public partial class MakeBookingForm : Form
    {

        #region Data Members

        Booking booking;
        BookingController bookingController;
        public bool bookingFormClosed = false;

        DataSet ds = new DataSet();
        //idk where it is
        SqlConnection conDB = new SqlConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();

        private bool isOpen;

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
            this.isOpen = false;
            this.Load += MakeBookingForm_Load1;
            this.Activated += MakeBookingForm_Activated;

        }

        private void MakeBookingForm_Activated(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MakeBookingForm_Load1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Utility Methods

        private void PopulateObject()
        {
            booking = new Booking();
            booking.BookingID = txtBookingID.Text;
            booking.CustomerID = txtCustID.Text;
            booking.ArriveDate = dateTimePickerArrival.Value;
            booking.LeaveDate = dateTimePickerDepartureDate.Value;


        }

        private void ClearAll()
        {
            txtBookingID.Text = "";
            txtCustID.Text = string.Empty;
            dateTimePickerArrival.Value = DateTime.Today;
            dateTimePickerDepartureDate.Value = DateTime.Today;
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
            if (txtCustID.Text.Equals("") || txtCustID.TextLength != 13)
            {
                MessageBox.Show("Please enter a valid CustomerID");
            }
            else
                if (this.dateTimePickerDepartureDate.Value < this.dateTimePickerArrival.Value)
            {
                MessageBox.Show("Cannot choose a departure date that is before the arrival date");
            }
            else
                if (!this.txtPaid.Text.Equals("T") || !this.txtPaid.Text.Equals("F"))
            {
                MessageBox.Show("Please enter a (T) or (F) to indicate whther the customer has paid");
            }

            //}else if(){
            //need to check whether a room is available
            //}
            else
            {
                //Added paid as a boolean value to be added to the database
                SqlCommand commIns = new SqlCommand("INSERT INTO Booking(BookingID, CustomerID, ArriveDate, LeaveDate, Deposit, RoomID, CardNumber, Paid" +
                                                       "VALUES(@CustomerID, @ArriveDate, @LeaveDate, @Deposit, @RoomID, @Paid", conDB);

                commIns.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 50, "CustomerID").Value = txtCustID.Text;
                commIns.Parameters.Add("@BookingID", SqlDbType.NVarChar, 50, "BookingID").Value = txtBookingID.Text;

                //i don't know whther to use text or value for the date time pickers
                commIns.Parameters.Add("@ArriveDate", SqlDbType.NVarChar, 50, "ArriveDate").Value = dateTimePickerArrival.Text;
                commIns.Parameters.Add("@LeaveDate", SqlDbType.NVarChar, 50, "LeaveDate").Value = dateTimePickerDepartureDate;
                commIns.Parameters.Add("@RoomID", SqlDbType.NVarChar, 50, "RoomID").Value = txtRoomNum.Text;
                //need to have a calculated value here
                commIns.Parameters.Add("Deposit", SqlDbType.NVarChar, 50, "Deposit").Value = 0;

                commIns.Parameters.Add("@Paid", SqlDbType.NVarChar, 50, "Paid").Value = txtPaid.Text;
                commIns.Parameters.Add("@CardNumber", SqlDbType.NVarChar, 50, "CardNumber").Value = txtCardNum.Text;

                commIns.ExecuteNonQuery();
                PopulateObject();
                MessageBox.Show("Succesfully added to database");
                bookingController.DataMaintanence(booking);
                bookingController.FinalizeChanges(booking);


                ClearAll();

            }


        }

        private void MakeBookingForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        #endregion

    }
}
