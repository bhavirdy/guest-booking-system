using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuestBookingSystem.Business;


namespace GuestBookingSystem.Presentation
{
    public partial class MakeBookingForm : Form
    {

        Booking booking;
        BookingController bookingController;
        public bool bookingFormClosed = false;
        public MakeBookingForm()
        {
            InitializeComponent();
        }

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
            }else
                if(this.dateTimePickerDepartureDate.Value < this.dateTimePickerArrival.Value)
            {
                MessageBox.Show("Cannot choose a departure date that is before the arrival date");

            }else if(){
                //need to check whether a room is available
            }
            else
            {
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
    }
}
