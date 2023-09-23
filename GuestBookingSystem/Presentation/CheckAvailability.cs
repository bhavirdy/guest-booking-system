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
    public partial class CheckAvailability : Form
    {
        private bool isOpen = false;
        private CustomerController customerController;

        public bool IsOpen
        {
            get { return isOpen; }
        }

        public CheckAvailability()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateCustomerForm createCustomerForm = new CreateCustomerForm(customerController);
            createCustomerForm.MdiParent = this.MdiParent;
            createCustomerForm.Show();
        }

        private void CheckAvailability_Load(object sender, EventArgs e)
        {
            isOpen = true;
        }

        private void CheckAvailability_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            isOpen = false;
        }
    }
}
