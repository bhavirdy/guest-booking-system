using GuestBookingSystem.Business;
using GuestBookingSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static GuestBookingSystem.Presentation.CustomerListingForm;

namespace GuestBookingSystem.Presentation
{
    public partial class BookingListingForm : Form
    {
        #region Data Members

        private bool isOpen = false;
        private Collection<Booking> bookings;
        private BookingController bookingController;
        private FormStates state;
        private Booking booking;

        private enum FormStates
        {
            View = 0,
            Add = 1,
            Edit = 2,
            Delete = 3,
        }
        #endregion

        public bool IsOpen
        {
            get { return isOpen; }
        }

        #region Constructor

        public BookingListingForm(BookingController bookingControllerTemp)
        {
            InitializeComponent();
            this.isOpen = true;
            bookingController = bookingControllerTemp;
            this.Load += BookingListingForm_Load;
            this.Activated += BookingListingForm_Activated;
            this.FormClosed += BookingListingForm_FormClosed;
            state = FormStates.View;
        }
        #endregion 

        #region Form events
        private void BookingListingForm_Load(object sender, EventArgs e)
        {
            bookingListView.View = View.Details;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            state = FormStates.Edit;
            EnableEntries(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            state = FormStates.Delete;
            EnableEntries(true);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            PopulateObject();

            if (state == FormStates.Edit)
            {
                bookingController.DataMaintanence(booking, Data.DB.DBOperation.Edit);
            }
            else
            {
                bookingController.DataMaintanence(booking, Data.DB.DBOperation.Delete);
            }

            bookingController.FinalizeChanges(booking);
            ClearAll();
            state = FormStates.View;
            setUpBookingListView();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableEntries(false);
            ClearAll();
            this.Close();
        }

        private void BookingListingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.isOpen = false;
        }

        private void BookingListingForm_Activated(object sender, EventArgs e)
        {
            bookingListView.View = View.Details;
            setUpBookingListView();
            ShowAll(false);
        }

        private void bookingListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll(true);
            state = FormStates.View;
            EnableEntries(false);
            if (bookingListView.SelectedItems.Count > 0)
            {
                booking = bookingController.Find(bookingListView.SelectedItems[0].Text);
                PopulateTextBoxes(booking);
            }
        }

        #endregion

        #region Utility methods
        private void ShowAll(bool value)
        {
            if (state == FormStates.Delete)
            {
                btnCancel.Visible = !value;
                btnSubmit.Visible = !value;
            }
            else
            {
                btnCancel.Visible = value;
                btnSubmit.Visible = value;
            }
            btnDelete.Visible = value;
            btnEdit.Visible = value;
        }

        private void setUpBookingListView()
        {
            ListViewItem bookingDetails;

            bookingListView.Clear();
            bookingListView.Columns.Insert(0, "BookingID", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(1, "CustomerID", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(2, "ArriveDate", 150, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(3, "LeaveDate", 100, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(4, "RoomID", 100, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(5, "Deposit", 100, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(6, "PricePerNight", 100, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(7, "TotalPrice", 100, HorizontalAlignment.Left);

            bookings = bookingController.Bookings;

            foreach (Booking booking in bookings)
            {
                bookingDetails = new ListViewItem();
                bookingDetails.Text = booking.BookingID.ToString();
                bookingDetails.SubItems.Add(booking.CustomerID.ToString());
                bookingDetails.SubItems.Add(booking.ArriveDate.ToString());
                bookingDetails.SubItems.Add(booking.LeaveDate.ToString());
                bookingDetails.SubItems.Add(booking.RoomNumber.ToString());
                bookingDetails.SubItems.Add(booking.Deposit.ToString());
                bookingDetails.SubItems.Add(booking.PricePerNight.ToString());
                bookingDetails.SubItems.Add(booking.TotalPrice.ToString());

                bookingListView.Items.Add(bookingDetails);
            }
            bookingListView.Refresh();
            bookingListView.GridLines = true;
        }

        private void EnableEntries(bool value)
        {
            if ((state == FormStates.Edit) && value)
            {
                txtCustomerID.Enabled = value;
                txtCardNumber.Enabled = value;
                dateArrival.Enabled = value;
                dateDeparture.Enabled = value;
            }

            btnCancel.Visible = value;
            btnSubmit.Visible = value;
        }

        private void ClearAll()
        {
            txtBookingID.Text = "";
            txtCustomerID.Text = "";
            txtCardNumber.Text = "";
            dateArrival.Value = DateTime.Now;
            dateDeparture.Value = DateTime.Now;
        }

        private void PopulateTextBoxes(Booking bookingTemp)
        {
            txtBookingID.Text = bookingTemp.BookingID;
            txtCustomerID.Text = bookingTemp.CustomerID;
            dateArrival.Value = bookingTemp.ArriveDate;
            dateDeparture.Value = bookingTemp.LeaveDate;
            txtCardNumber.Text= bookingTemp.CardNumber;
        }

        private void PopulateObject()
        {
            booking = new Booking();
            booking.BookingID = txtBookingID.Text;
            booking.CustomerID = txtCustomerID.Text;
            booking.ArriveDate = dateArrival.Value;
            booking.LeaveDate = dateDeparture.Value;
            booking.CardNumber = txtCardNumber.Text;
        }


        #endregion
    }
}
