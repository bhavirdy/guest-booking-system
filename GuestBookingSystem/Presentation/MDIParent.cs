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
        private EditCustomerForm editCustomersForm;
        private MakeBookingForm makeBookingForm;
        private EditBookingForm editBookingForm;
        private DeleteCustomerForm deleteCustomerForm;
        private DeleteBookingForm deleteBookingForm;
        private ViewTables viewTables;
        private CreateCustomerForm createCustomerForm;
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

        private void editCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editCustomersForm == null)
            {
                EditCustomerForm();
            }
            else
                if (!editCustomersForm.IsOpen)
            {
                EditCustomerForm();
            }

        }

        public void EditCustomerForm()
        {
            editCustomersForm = new EditCustomerForm();
            editCustomersForm.MdiParent = this;
            editCustomersForm.Show();

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

        private void editBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editBookingForm == null)
            {
                EditBookingForm();
            }
            else
                if (!editBookingForm.IsOpen)
            {
                EditBookingForm();
            }

        }

        private void EditBookingForm()
        {
            editBookingForm = new EditBookingForm();
            editBookingForm.MdiParent = this;
            editBookingForm.Show();
        }

        #endregion

        private void deleteACustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deleteCustomerForm == null)
            {
                DeleteCustomerForm();
            }
            else if (!deleteCustomerForm.IsOpen)
            {
                DeleteCustomerForm();
            }
        }

        private void DeleteCustomerForm()
        {
            deleteCustomerForm = new DeleteCustomerForm();
            deleteCustomerForm.MdiParent = this;
            deleteCustomerForm.Show();
        }

        private void deleteABookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deleteBookingForm == null)
            {
                DeleteBookingForm();
            }
            else if (!deleteBookingForm.IsOpen)
            {
                DeleteBookingForm();
            }
        }

        private void DeleteBookingForm()
        {
            deleteBookingForm = new DeleteBookingForm();
            deleteBookingForm.MdiParent = this;
            deleteBookingForm.Show();
        }

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
    }
}
