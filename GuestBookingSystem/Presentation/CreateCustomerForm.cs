using GuestBookingSystem.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuestBookingSystem.Business;
using GuestBookingSystem.Properties;
using System.Text.RegularExpressions;

namespace GuestBookingSystem.Presentation
{
    public partial class CreateCustomerForm : Form
    {

        #region Data Members

        private Customer customer = new Customer();
        private CustomerController customerController;
        public bool customerFormClosed = false;
        DateTime dateA;
        DateTime dateD;

        private bool isOpen = false;

        #endregion

        #region Constructor

        public CreateCustomerForm(CustomerController controllerTemp, DateTime date1, DateTime date2)
        {
            InitializeComponent();
            customerController = controllerTemp;
            dateA = date1;
            dateD = date2;
            isOpen = true;
        }

        #endregion

        #region Property Methods
        public bool IsOpen
        {
            set { isOpen = value; }
            get { return isOpen; }
        }

        #endregion

        #region Utility methods

        private void ClearAll()
        {

            txtTownOrCity.Text = "";
            txtProvince.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtPhoneNum.Text = "";
            txtPostalCode.Text = "";
            txtStreetA.Text = "";
            txtSurname.Text = "";
        }

        private void PopulateObject()
        {
            customer.StreetAddress = txtStreetA.Text;
            customer.Email = txtEmail.Text;
            customer.Name = txtName.Text;
            customer.PostalCode = txtPostalCode.Text;
            customer.Phone = txtPhoneNum.Text;
            customer.Surname = txtSurname.Text;
            customer.TownOrCity = txtTownOrCity.Text;
            customer.Province = txtProvince.Text;
            customer.CustID = customerController.getUniqueCustomerID();
      
        }

        #endregion

        #region Helper methods for integrity checks
        public static bool IsNDigitNumber(string input, int numberOfDigits)
        {
            //Define pattern for an n digit number
            string pattern = @"^\d{" + numberOfDigits + "}$";

            //Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            //Check if the input string matches pattern
            return regex.IsMatch(input);
        }

        public static bool ContainsOnlyLettersAndSpaces(string input)
        {
            //Define pattern for only letters
            string pattern = @"^[A-Za-z\s]+$";

            //Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            //Check if the input string matches pattern
            return regex.IsMatch(input);
        }

        public static bool ContainsOnlyLettersSpacesAndNumbers(string input)
        {
            //Define pattern for letters, spaces, and numbers
            string pattern = @"^[A-Za-z0-9\s]+$";

            //Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            //Check if the input string matches pattern
            return regex.IsMatch(input);
        }

        public static bool IsValidEmail(string email)
        {
            //Define pattern for a valid email address
            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";

            //Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            //Check if the email matches the pattern
            return regex.IsMatch(email);
        }
        public bool IntegrityCheck()
        {
            //Check empty fields
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtSurname.Text) ||
                string.IsNullOrWhiteSpace(txtStreetA.Text) ||
                string.IsNullOrWhiteSpace(txtTownOrCity.Text) ||
                string.IsNullOrWhiteSpace(txtProvince.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNum.Text) ||
                string.IsNullOrWhiteSpace(txtPostalCode.Text))
            {
                MessageBox.Show("Please ensure all the fields are filled.");
                return false;
            }

            //Check each textbox
            if (!IsNDigitNumber(txtPhoneNum.Text, 10))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return false;
            }

            if (!ContainsOnlyLettersSpacesAndNumbers(txtStreetA.Text))
            {
                MessageBox.Show("Please enter a valid street address.");
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

            //Data is valid
            return true;
        }

        #endregion

        #region Form Events
        private void CreateCustomerForm_Activated(object sender, EventArgs e)
        {

        }

        private void btnSubmitC_Click(object sender, EventArgs e)
        {

            if (IntegrityCheck())
            {
                PopulateObject();
                MessageBox.Show("Customer entered!");
                customerController.DataMaintanence(customer, Data.DB.DBOperation.Add);
                customerController.FinalizeChanges(customer);

            }

            MakeBookingForm makeBookingForm = new MakeBookingForm(customer.CustID, dateA, dateD);
            makeBookingForm.MdiParent = this.MdiParent;
            this.Close();
            makeBookingForm.Show();
            ClearAll();
        }

        private void CreateCustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
        }

        private void CreateCustomerForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnClearC_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnCancelC_Click(object sender, EventArgs e)
        {
            CheckAvailability caForm = new CheckAvailability();
            caForm.MdiParent = this.MdiParent;
      
            caForm.Show();
            this.isOpen = false;
            this.Close();
        }
    }
    #endregion

}