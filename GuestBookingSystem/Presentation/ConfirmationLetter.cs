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
        #region Constructor
        public ConfirmationLetter(string reference, DateTime dateA, DateTime dateD)
        {
            InitializeComponent();
            lblRefNumOut.Text = reference;
            lblArrivalDateOut.Text = dateA.ToString();
            lblDepartureDateOut.Text = dateD.ToString();
        }
        #endregion

        #region Form Events
        private void ConfirmationLetter_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRefNumOut_Click(object sender, EventArgs e)
        {

        }
    }
}
