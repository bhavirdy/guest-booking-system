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
    public partial class MDIParent : Form
    {

        #region Data Members
        private int childFormNumber = 0;
        private CheckAvailability checkAvailability;
        private MakeBookingForm makeBookingForm;
        private ViewTables viewTables;
        private CreateCustomerForm createCustomerForm;
        private CustomerListingForm customerListingForm;
        private CustomerController customerController = new CustomerController();

        #endregion

        #region Constructor


        public MDIParent()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        #endregion

        #region Form Events

        private void MDIParent_Load(object sender, EventArgs e)
        {

        }

        public void MakeaBookingForm()
        {
            makeBookingForm = new MakeBookingForm();
            makeBookingForm.MdiParent = this;
            makeBookingForm.Show();
        }

        private void createABookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (makeBookingForm == null)
            {
                MakeaBookingForm();
            }
            else
                if (!makeBookingForm.IsOpen)
            {
                MakeaBookingForm();
            }
        }

        #endregion

        private void ViewTables()
        {
            viewTables = new ViewTables();
            viewTables.MdiParent = this;
            viewTables.Show();
        }

        private void viewTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewTables == null)
            {
                ViewTables();
            }
            else if (!viewTables.IsOpen)
            {
                ViewTables();
            }
        }

        private void checkAvailabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkAvailability == null)
            {
                CheckAvailability();
            }
            else if (!checkAvailability.IsOpen)
            {
                CheckAvailability();
            }
        }

        public void CheckAvailability()
        {
            checkAvailability = new CheckAvailability();
            checkAvailability.MdiParent = this;
            checkAvailability.Show();
        }

        private void createACustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (createCustomerForm == null)
            //{
            //    CreateCustomer();
            //}
            //else if (!createCustomerForm.IsOpen)
            //{
            //    CreateCustomer();
            //}
        }

        public void CreateCustomer()
        {
            createCustomerForm = new CreateCustomerForm(customerController);
            createCustomerForm.MdiParent = this;
            createCustomerForm.Show();
        }

        private void customerListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customerListingForm == null)
            {
                CustomerListing();
            }
            else if (!customerListingForm.IsOpen)
            {
                CustomerListing();
            }
        }

        public void CustomerListing()
        {
            customerListingForm = new CustomerListingForm(customerController);
            customerListingForm.MdiParent = this;
            customerListingForm.Show();
        }
    }
}
