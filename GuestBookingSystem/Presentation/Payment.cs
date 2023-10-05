using GuestBookingSystem.Business;
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
        public Payment(string reference, DateTime dateA, DateTime dateD)
        {
            InitializeComponent();
            this.reference = reference;
            this.date1 = dateA;
            this.date2 = dateD;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please inform the customer that they will need to pay the deposit within seven days or their booking will be cancelled");
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for making the deposit");
            ConfirmationLetter cl = new ConfirmationLetter(reference, date1, date2); ;
            cl.Show();
            this.Close();
        }
    }
}
