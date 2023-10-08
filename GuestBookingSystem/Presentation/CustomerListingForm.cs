using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using GuestBookingSystem.Business;
using GuestBookingSystem.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Xml;
using System.Text.RegularExpressions;

namespace GuestBookingSystem.Presentation
{
    public partial class CustomerListingForm : Form
    {

        #region Data Members

        private bool isOpen = false;
        private Collection<Customer> customers;
        private CustomerController customerController;
        private FormStates state;
        private Customer customer;

        public enum FormStates
        {
            View = 0,
            Add = 1,
            Edit = 2,
            Delete = 3
        }

        #endregion

        #region Property Methods

        public bool IsOpen
        {
            get { return isOpen; }
        }

        #endregion

        #region Constructor

        public CustomerListingForm(CustomerController customerControllerTemp)
        {
            InitializeComponent();
            this.isOpen = true;
            customerController = customerControllerTemp;
            this.Load += CustomerListingForm_Load;
            this.Activated += CustomerListingForm_Activated;
            this.FormClosed += CustomerListingForm_FormClosed;
            state = FormStates.View;
        }

        #endregion

        #region Form Events
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //if integrity check is passed, continue
            if (IntegrityCheck())
            {
                PopulateObject();

                if (state == FormStates.Edit)
                {
                    customerController.DataMaintanence(customer, Data.DB.DBOperation.Edit);
                }
                else
                {
                    customerController.DataMaintanence(customer, Data.DB.DBOperation.Delete);
                }

                customerController.FinalizeChanges(customer);
                ClearAll();
                state = FormStates.View;
                setUpCustomerListView();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            state = FormStates.Delete;
            EnableEntries(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            state = FormStates.Edit;
            EnableEntries(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            EnableEntries(false);
            ClearAll();
            this.Close();
        }
        private void CustomerListingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.isOpen = false;
        }

        private void CustomerListingForm_Activated(object sender, EventArgs e)
        {
            customerListView.View = View.Details;
            setUpCustomerListView();
            ShowAll(false);
        }

        private void CustomerListingForm_Load(object sender, EventArgs e)
        {
            customerListView.View = View.Details;
            this.WindowState = FormWindowState.Maximized;
        }

        private void customerListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll(true);
            state = FormStates.View;
            EnableEntries(false);
            if (customerListView.SelectedItems.Count > 0)
            {
                customer = customerController.Find(customerListView.SelectedItems[0].Text);
                PopulateTextBoxes(customer);
            }

        }
        #endregion

        #region Utility Methods

        private void setUpCustomerListView()
        {
            ListViewItem customerDetails;
            customerListView.Clear();
            customerListView.Columns.Insert(0, "CustomerID", 120, HorizontalAlignment.Left);
            customerListView.Columns.Insert(1, "Name", 120, HorizontalAlignment.Left);
            customerListView.Columns.Insert(2, "Surname", 150, HorizontalAlignment.Left);
            customerListView.Columns.Insert(3, "Email", 100, HorizontalAlignment.Left);
            customerListView.Columns.Insert(4, "StreetAddress", 100, HorizontalAlignment.Left);
            customerListView.Columns.Insert(5, "TownOrCity", 100, HorizontalAlignment.Left);
            customerListView.Columns.Insert(6, "Province", 100, HorizontalAlignment.Left);
            customerListView.Columns.Insert(7, "PostalCode", 100, HorizontalAlignment.Left);
            customerListView.Columns.Insert(8, "Phone", 100, HorizontalAlignment.Left);

            customerController = new CustomerController();
            customers = customerController.CustomerCollection;

            foreach (Customer customer in customers)
            {
                customerDetails = new ListViewItem();
                customerDetails.Text = customer.CustID.ToString();
                customerDetails.SubItems.Add(customer.Name);
                customerDetails.SubItems.Add(customer.Surname);
                customerDetails.SubItems.Add(customer.Email);
                customerDetails.SubItems.Add(customer.StreetAddress);
                customerDetails.SubItems.Add(customer.TownOrCity);
                customerDetails.SubItems.Add(customer.Province);
                customerDetails.SubItems.Add(customer.PostalCode);
                customerDetails.SubItems.Add(customer.Phone);

                customerListView.Items.Add(customerDetails);
            }
            customerListView.Refresh();
            customerListView.GridLines = true;

        }

        private void EnableEntries(bool value)
        {
            if ((state == FormStates.Edit) && value)
            {
                txtEmail.Enabled = value;
                txtName.Enabled = value;
                txtPhone.Enabled = value;
                txtPostalCode.Enabled = value;
                txtProvince.Enabled = value;
                txtStreetAddress.Enabled = value;
                txtSurname.Enabled = value;
                txtTownOrCity.Enabled = value;
            }

            btnCancel.Visible = value;
            btnSubmit.Visible = value;
        }

        private void ShowAll(bool value)
        {

            if (state == FormStates.Delete)
            {
                btnCancel.Visible = !value;
                btnSubmit.Visible = !value;
            }
            else
            {
                btnCancel.Visible = value;
                btnSubmit.Visible = value;
            }
            btnDelete.Visible = value;
            btnEdit.Visible = value;

        }

        private void ClearAll()
        {
            txtCustomerID.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtEmail.Text = "";
            txtStreetAddress.Text = "";
            txtTownOrCity.Text = "";
            txtProvince.Text = "";
            txtPhone.Text = "";
            txtPostalCode.Text = "";
        }

        private void PopulateTextBoxes(Customer customerTemp)
        {
            txtCustomerID.Text = customerTemp.CustID;
            txtName.Text = customerTemp.Name;
            txtSurname.Text = customerTemp.Surname;
            txtEmail.Text = customerTemp.Email;
            txtStreetAddress.Text = customerTemp.StreetAddress;
            txtTownOrCity.Text = customerTemp.TownOrCity;
            txtProvince.Text = customerTemp.Province;
            txtPhone.Text = customerTemp.Phone;
            txtPostalCode.Text = customerTemp.PostalCode;
        }

        private void PopulateObject()
        {
            customer = new Customer();
            customer.CustID = txtCustomerID.Text;
            customer.Name = txtName.Text;
            customer.Surname = txtSurname.Text;
            customer.Email = txtEmail.Text;
            customer.StreetAddress = txtStreetAddress.Text;
            customer.TownOrCity = txtTownOrCity.Text;
            customer.Province = txtProvince.Text;
            customer.PostalCode = txtPostalCode.Text;
            customer.Phone = txtPhone.Text;
        }


        #endregion

        #region Integrity helper methods

        public static bool IsNDigitNumber(string input, int numberOfDigits)
        {
            //Define pattern for an n digit number
            string pattern = @"^\d{" + numberOfDigits + "}$";

            //Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            //Check if input string matches the pattern
            return regex.IsMatch(input);
        }

        public static bool ContainsOnlyLettersAndSpaces(string input)
        {
            //Define pattern for only letters
            string pattern = @"^[A-Za-z\s]+$";

            //Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            //Check if input string matches pattern
            return regex.IsMatch(input);
        }

        public static bool IsValidEmail(string email)
        {
            //Define pattern for a valid email address
            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";

            // Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            // Check if the email matches pattern
            return regex.IsMatch(email);
        }

        //method to carry out integrity check on all relevent fields
        public bool IntegrityCheck()
        {
            //Check empty fields
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtSurname.Text) ||
                string.IsNullOrWhiteSpace(txtStreetAddress.Text) ||
                string.IsNullOrWhiteSpace(txtTownOrCity.Text) ||
                string.IsNullOrWhiteSpace(txtProvince.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtPostalCode.Text))
            {
                MessageBox.Show("Please ensure all the fields are filled.");
                return false;
            }

            //Check each textbox
            if (!IsNDigitNumber(txtPhone.Text, 10))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return false;
            }

            if (!IsNDigitNumber(txtPostalCode.Text, 4))
            {
                MessageBox.Show("Please enter a valid postal code.");
                return false;
            }

            if (!ContainsOnlyLettersAndSpaces(txtTownOrCity.Text))
            {
                MessageBox.Show("Please enter a valid city.");
                return false;
            }

            if (!ContainsOnlyLettersAndSpaces(txtProvince.Text))
            {
                MessageBox.Show("Please enter a valid province.");
                return false;
            }

            if (!ContainsOnlyLettersAndSpaces(txtName.Text))
            {
                MessageBox.Show("Please enter a valid name.");
                return false;
            }

            if (!ContainsOnlyLettersAndSpaces(txtSurname.Text))
            {
                MessageBox.Show("Please enter a valid surname.");
                return false;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return false;
            }

            //data is valid
            return true;
        }

        #endregion 
    }
}
