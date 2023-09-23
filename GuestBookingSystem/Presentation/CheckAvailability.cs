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

        public bool IsOpen
        {
            get { return isOpen; }
        }

        public CheckAvailability()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {

        }

        private void CheckAvailability_Load(object sender, EventArgs e)
        {
            isOpen = true;
        }

        private void CheckAvailability_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
        }
    }
}
