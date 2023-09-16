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
    public partial class EditCustomersForm : Form
    {

        #region Data Members
        private Customer customer;
        private CustomerController custController;
        public EditCustomersForm()
        {
            InitializeComponent();
        }

        private void lblHeadingEditC_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
