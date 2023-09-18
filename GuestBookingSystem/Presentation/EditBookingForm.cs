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
    public partial class EditBookingForm : Form
    {

        #region Data Members
        public bool listFormClosed;
        private Collection<Booking> bookings;
        private BookingController bookingController;
        private Booking booking;

        #endregion 

        #region Constructor

        public EditBookingForm()
        {
            InitializeComponent();
            this.Load += EditBookingForm_Load;
            this.Activated += EditBookingForm_Activated;

        }

        public EditBookingForm(BookingController bookingController)
        {
            InitializeComponent();
            this.bookingController = bookingController;
            this.Load += EditBookingForm_Load;
            this.Activated += EditBookingForm_Activated;
        }

        #endregion 

        private void EditBookingForm_Activated(object sender, EventArgs e)
        {
            bookingView.View = View.Details;
            setUpCustomerListView();
            ClearAll();
        }

        #region ListView Setup

        public void setUpCustomerListView()
        {
            ListViewItem bookingDetails = null;

            booking = null;
            bookingView.Clear();

            bookingView.Columns.Insert(0, "BookingID", 120, HorizontalAlignment.Left);
            bookingView.Columns.Insert(0, "CustomerID", 120, HorizontalAlignment.Left);
            bookingView.Columns.Insert(0, "ArriveDate", 120, HorizontalAlignment.Left);
            bookingView.Columns.Insert(0, "LeaveDate", 120, HorizontalAlignment.Left);
            bookingView.Columns.Insert(0, "RoomID", 120, HorizontalAlignment.Left);
            bookingView.Columns.Insert(0, "Deposit", 120, HorizontalAlignment.Left);

            foreach(Booking booking in bookings)
            {
                bookingDetails = new ListViewItem();
                bookingDetails.Text = booking.BookingID.ToString();
                bookingDetails.SubItems.Add(booking.BookingID.ToString());
                bookingDetails.SubItems.Add(booking.CustomerID.ToString());
                bookingDetails.SubItems.Add(booking.ArriveDate.ToString());
                bookingDetails.SubItems.Add(booking.LeaveDate.ToString());
                bookingDetails.SubItems.Add(booking.RoomNumber.ToString());
                bookingDetails.SubItems.Add(booking.Deposit.ToString());

                bookingView.Items.Add(bookingDetails);
            }

            bookingView.Refresh();
            bookingView.GridLines = true;

            
        }

        private void bookingView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(bookingView.SelectedItems.Count > 0)
            {
                booking = bookingController.Find(bookingView.SelectedItems[0].Text);
                PopulateTextBoxes(booking);
            }
        }

        #region Utility Methods

        private void ClearAll()
        {
            txtCustID.Text = "";
            dateTimePickerArrival.Text = "";
            dateTimePickerDepartureDate.Text = "";
            txtRoomNum.Text = "";


        }

        //not complete

        private void PopulateTextBoxes(Booking bookTemp)
        {
            txtCustID.Text = bookTemp.CustomerID.ToString();
            dateTimePickerArrival.Text = bookTemp.ArriveDate.ToString();

        }



        private void lblHeadingEdit_Click(object sender, EventArgs e)
        {

        }

        private void txtRoomNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditBookingForm_Load(object sender, EventArgs e)
        {

        }

        private void txtCustID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmitV_Click(object sender, EventArgs e)
        {
            //needs to check if inputted room is available
            if (txtCustID.Text.Equals("") || txtRoomNum.Text.Equals(""))
            {
                MessageBox.Show("Please fill out all the fields");
            }
            else
                if (dateTimePickerArrival.Value > dateTimePickerDepartureDate.Value)
            {
                MessageBox.Show("Arrival date cannot be after departure date");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnExitV_Click(object sender, EventArgs e)
        {
            this.listFormClosed = true;
        }
    }
}
