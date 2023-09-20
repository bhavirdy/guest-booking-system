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
    public partial class DeleteCustomerForm : Form
    {

        private bool isOpen = false;

        public bool IsOpen
        {
            get { return isOpen; }
            set { isOpen = value; }
        }

        public DeleteCustomerForm()
        {
            InitializeComponent();
            isOpen = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void DeleteCustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
        }
    }
}
