using GuestBookingSystem.Business;
using GuestBookingSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestBookingSystem.Presentation
{
    public partial class Payment : Form
    {
        private string reference;
        private DateTime date1;
        private DateTime date2;
        private String bookingID;
        public Payment(string reference, DateTime dateA, DateTime dateD, string bookingID)
        {
            InitializeComponent();
            this.reference = reference;
            this.date1 = dateA;
            this.date2 = dateD;
            this.bookingID = bookingID;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            //add to database, have to pass booking object 
            MessageBox.Show("Please inform the customer that they will need to pay the deposit within seven days or their booking will be cancelled");
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            //add to database 
            BookingDB bookingDB = new BookingDB();
            bookingDB.SetBookingPaid(bookingID);

            MessageBox.Show("Thank you for making the deposit");
            ConfirmationLetter cl = new ConfirmationLetter(reference, date1, date2); ;
            cl.Show();
            this.Close();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
