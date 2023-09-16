using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuestBookingSystem.Business;

namespace GuestBookingSystem.Presentation
{
    public partial class CreateCustomerForm : Form
    {

        #region Data Members

        private Customer customer;
        private CustomerController customerController;
        public bool customerFormClosed = false;

        #endregion

        #region Constructor

        public CreateCustomerForm(CustomerController controllerTemp)
        {
            InitializeComponent();

            customerController = controllerTemp;
        }

        #endregion

        #region Utility methods

        private void ShowAll(bool value)
        {
            lblName.Visible = value;
            lblSurname.Visible = value;
            lblPhoneNumber.Visible = value;
            lblPostalCode.Visible = value;
            lblCountry.Visible = value;
            lblCity.Visible = value;
            lblEmail.Visible = value;
            lblCardNumber.Visible = value;
            lblStreetAdress.Visible = value;
            lblSuburb.Visible = value;
            txtCardNumber.Visible = value;
            txtCity.Visible = value;
            txtCountry.Visible = value;
            txtEmail.Visible = value;
            txtName.Visible = value;
            txtPhoneNum.Visible = value;
            txtPostalCode.Visible = value;
            txtStreetA.Visible = value;
            txtSurname.Visible = value;
            
        }

        private void ClearAll()
        {
            txtCardNumber.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtPhoneNum.Text = "";
            txtPostalCode.Text = "";
            txtStreetA.Text = "";
            txtSurname.Text = "";
            txtSuburb.Text = "";

        }

        private void PopulateObject()
        {
            customer.StreetAddress = txtStreetA.Text;
            customer.CardNumber = txtCardNumber.Text;
            customer.Email = txtEmail.Text;
            customer.Name = txtName.Text;
            customer.PostalCode = txtPostalCode.Text;
            customer.Phone = txtPhoneNum.Text;
            customer.Surname = txtSurname.Text;
            customer.Suburb = txtSuburb.Text;


        }

        #endregion

        #region Form Events
        private void btnSubmitC_Click(object sender, EventArgs e)
        {
            PopulateObject();
            MessageBox.Show("Customer entered!");
            customerController.DataMaintanence(customer);
            customerController.FinalizeChanges(customer);
            ClearAll();
            ShowAll(true);

        }

        private void CreateCustomerForm_Load(object sender, EventArgs e)
        {
            ShowAll(true);


        }

        private void lblHeadingCreateCustomer_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnClearC_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnCancelC_Click(object sender, EventArgs e)
        {
            customerFormClosed = true;
        }

        #endregion 
    }
}
