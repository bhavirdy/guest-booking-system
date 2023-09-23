using GuestBookingSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        DataSet ds = new DataSet();
        SqlConnection conDB = new SqlConnection();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();

        private bool isOpen;

        #endregion

        #region Property Members

        public bool IsOpen
        {
            get { return isOpen; }
            set { isOpen = value; }
        }


        #endregion 

        #region Constructor

        public EditBookingForm()
        {
            InitializeComponent();
            //this.Load += EditBookingForm_Load;
            //this.Activated += EditBookingForm_Activated;

            isOpen = true;
        }

        //public EditBookingForm(BookingController bookingController)
        //{
        //    InitializeComponent();
        //    this.bookingController = bookingController;
        //    this.Load += EditBookingForm_Load;
        //    this.Activated += EditBookingForm_Activated;
        //}

        #endregion 

        //private void EditBookingForm_Activated(object sender, EventArgs e)
        //{
        //    bookingView.Visible = true;
        //    setUpCustomerListView();
        //    ClearAll();
        //}

        #region ListView Setup

        //don't know if this is correct
        public void setUpCustomerListView()
        {
            ListViewItem bookingDetails = null;

            booking = null;
            bookingView.Clear();

            bookingView.Columns.Insert(0, "BookingID", 120, HorizontalAlignment.Left);
            bookingView.Columns.Insert(1, "CustomerID", 120, HorizontalAlignment.Left);
            bookingView.Columns.Insert(2, "ArriveDate", 120, HorizontalAlignment.Left);
            bookingView.Columns.Insert(3, "LeaveDate", 120, HorizontalAlignment.Left);
            bookingView.Columns.Insert(4, "RoomID", 120, HorizontalAlignment.Left);
            bookingView.Columns.Insert(5, "Deposit", 120, HorizontalAlignment.Left);

            //bookingView.Columns.Insert(6, "CardNumber", 120, HorizontalAlignment.LEFT);
            //bookingView.Columns.Insert(7, "Paid", 120, HorizontalAlignment.LEFT);

            foreach (Booking booking in bookings)
            {
                bookingDetails = new ListViewItem();
                bookingDetails.Text = booking.BookingID.ToString();
                bookingDetails.SubItems.Add(booking.BookingID.ToString());
                bookingDetails.SubItems.Add(booking.CustomerID.ToString());
                bookingDetails.SubItems.Add(booking.ArriveDate.ToString());
                bookingDetails.SubItems.Add(booking.LeaveDate.ToString());
                bookingDetails.SubItems.Add(booking.RoomNumber.ToString());
                bookingDetails.SubItems.Add(booking.Deposit.ToString());

                //bookingDetails.SubItems.Add(booking.CardNumber.ToString());
                //bookingDetails.SubItems.Add(booking.Paid.ToString());

                bookingView.Items.Add(bookingDetails);
            }

            bookingView.Refresh();
            bookingView.GridLines = true;


        }

        #endregion 

        private void bookingView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookingView.SelectedItems.Count > 0)
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
            txtCardNumber.Text = "";
            txtPaid.Text = "";


        }

        #endregion

        #region Utility Methods

        private void PopulateTextBoxes(Booking bookTemp)
        {
            txtCustID.Text = bookTemp.CustomerID.ToString();
            dateTimePickerArrival.Value = bookTemp.ArriveDate;
            dateTimePickerDepartureDate.Value = bookTemp.LeaveDate;
            txtRoomNum.Text = bookTemp.RoomNumber.ToString();
            txtCardNumber.Text = bookTemp.CardNumber.ToString();
            txtPaid.Text = bookTemp.Paid.ToString();
            txtDeposit.Text = bookTemp.Deposit.ToString();


        }

        private void PopulateObject()
        {
            booking = new Booking();
            booking.CustomerID = txtCustID.Text.ToString();
            booking.CardNumber = Convert.ToInt32(txtCardNumber.Text);
            booking.Deposit = Convert.ToDouble(txtDeposit.Text);
            booking.ArriveDate = dateTimePickerArrival.Value;
            booking.LeaveDate = dateTimePickerDepartureDate.Value;
            booking.RoomNumber = Convert.ToInt32(txtRoomNum.Text);

        }

        public void setUpBookingListView()
        {
            ListViewItem bookingDetails = new ListViewItem();
            bookings = null;
            this.bookingView.Clear();

            bookingView.Columns.Insert(0, "BookingID", 120, HorizontalAlignment.Left);
            bookingView.Columns.Insert(1, "CustomerID", 120, HorizontalAlignment.Left);
            bookingView.Columns.Insert(2, "ArriveDate", 120, HorizontalAlignment.Left);
            bookingView.Columns.Insert(3, "LeaveDate", 120, HorizontalAlignment.Left);
            bookingView.Columns.Insert(4, "RoomID", 120, HorizontalAlignment.Left);
            bookingView.Columns.Insert(5, "Deposit", 120, HorizontalAlignment.Left);
            bookingView.Columns.Insert(0, "Card Number", 120, HorizontalAlignment.Left);
            bookingView.Columns.Insert(0, "Paid", 120, HorizontalAlignment.Left);


            //foreach (Booking booking in bookings)

        }

        private void EditBookingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
        }

        private void EditBookingForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmitV_Click(object sender, EventArgs e)
        {

        }

        //public EditBookingForm(BookingController bookingController)
        //{
        //    InitializeComponent();
        //    this.bookingController = bookingController;
        //    this.Load += EditBookingForm_Load;
        //    this.Activated += EditBookingForm_Activated;
        //}

        #endregion

        //private void EditBookingForm_Activated(object sender, EventArgs e)
        //{
        //    bookingView.View = View.Details;
        //    setUpCustomerListView();
        //    ClearAll();
        //}

        #region ListView Setup

        //public void setUpCustomerListView()
        //{
        //    ListViewItem bookingDetails = null;

        //    booking = null;
        //    bookingView.Clear();

        //    bookingView.Columns.Insert(0, "BookingID", 120, HorizontalAlignment.Left);
        //    bookingView.Columns.Insert(0, "CustomerID", 120, HorizontalAlignment.Left);
        //    bookingView.Columns.Insert(0, "ArriveDate", 120, HorizontalAlignment.Left);
        //    bookingView.Columns.Insert(0, "LeaveDate", 120, HorizontalAlignment.Left);
        //    bookingView.Columns.Insert(0, "RoomID", 120, HorizontalAlignment.Left);
        //    bookingView.Columns.Insert(0, "Deposit", 120, HorizontalAlignment.Left);

        //    foreach(Booking booking in bookings)

        //    {
        //        bookingDetails = new ListViewItem();
        //        bookingDetails.Text = booking.BookingID.ToString();
        //        bookingDetails.SubItems.Add(booking.BookingID.ToString());
        //        bookingDetails.SubItems.Add(booking.CustomerID.ToString());
        //        bookingDetails.SubItems.Add(booking.ArriveDate.ToString());
        //        bookingDetails.SubItems.Add(booking.LeaveDate.ToString());

        //        bookingDetails.SubItems.Add(booking.Deposit.ToString());
        //        bookingDetails.SubItems.Add(booking.CardNumber.ToString());
        //        bookingDetails.SubItems.Add(booking.Paid.ToString());

        //        bookingDetails.SubItems.Add(booking.RoomNumber.ToString());
        //        bookingDetails.SubItems.Add(booking.Deposit.ToString());


        //        bookingView.Items.Add(bookingDetails);
        //    }



        //    bookingView.Refresh();
        //    bookingView.GridLines = true;
        //}

        #endregion

        #region Form Events

        //    bookingView.Refresh();
        //    bookingView.GridLines = true;


        //}

        //private void bookingView_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if(bookingView.SelectedItems.Count > 0)
        //    {
        //        booking = bookingController.Find(bookingView.SelectedItems[0].Text);
        //        PopulateTextBoxes(booking);
        //    }
        //}

        #endregion

        #region Utility Methods

        //private void ClearAll()
        //{
        //    txtCustID.Text = "";
        //    dateTimePickerArrival.Text = "";
        //    dateTimePickerDepartureDate.Text = "";
        //    txtRoomNum.Text = "";


        //}

        ////not complete

        //private void PopulateTextBoxes(Booking bookTemp)
        //{
        //    txtCustID.Text = bookTemp.CustomerID.ToString();
        //    dateTimePickerArrival.Text = bookTemp.ArriveDate.ToString();

        //}




        //private void lblHeadingEdit_Click(object sender, EventArgs e)
        //{

        //}

        //private void txtRoomNum_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void EditBookingForm_Load(object sender, EventArgs e)
        //{

        //}

        //private void txtCustID_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void btnSubmitV_Click(object sender, EventArgs e)
        //{
        //    //needs to check if inputted room is available
        //    if (txtCustID.Text.Equals("") || txtRoomNum.Text.Equals(""))
        //    {
        //        MessageBox.Show("Please fill out all the fields");
        //    }
        //    else
        //        if (dateTimePickerArrival.Value > dateTimePickerDepartureDate.Value)
        //    {
        //        MessageBox.Show("Arrival date cannot be after departure date");
        //    }

        //    else
        //    {


        //        PopulateObject();
        //        bookingController.DataMaintanence(booking);
        //        bookingController.FinalizeChanges(booking);
        //        ClearAll();
        //        setUpBookingListView();
        //    }
        //}
        #endregion

        //private void btnClear_Click(object sender, EventArgs e)
        //{
        //    ClearAll();
        //}

        //private void btnExitV_Click(object sender, EventArgs e)
        //{
        //    this.listFormClosed = true;
        //}

    }
}
