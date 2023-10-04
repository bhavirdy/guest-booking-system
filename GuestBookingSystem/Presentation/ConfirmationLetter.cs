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
    public partial class ConfirmationLetter : Form
    {
        public ConfirmationLetter(string reference, DateTime dateA, DateTime dateD)
        {
            InitializeComponent();
            lblRefNumOut.Text = reference;
            lblArrivalDateOut.Text = dateA.ToString();
            lblDepartureDateOut.Text = dateD.ToString();

        }



        private void ConfirmationLetter_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
