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

        string[] numbersCheck = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };


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
            txtCustID.Text = "";
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
            customer.CustID = txtCustID.Text;
      
        }

        #endregion

        #region Helper methods for integrity checks

        //method to check if the pinut only includes Numeric characters
        private bool checkNumbers(String value)
        {

            bool check = false;
            for (int i = 0; i <= value.Length; i++)
            {
                string temp = value.Substring(i, i + 1);

                for (int j = 0; j < numbersCheck.Length; j++)
                {
                    if (!temp.Equals(numbersCheck[j]))
                    {
                        check = true;


                    }
                }
            }

            return check;


        }

        //method to check if the pinut only includes Numeric characters

        private bool checkLetters(String value)
        {
            bool check = false;
            for (int i = 0; i <= value.Length; i++)
            {
                string temp = value.Substring(i, i + 1);

                for (int j = 0; j < numbersCheck.Length; j++)
                {
                    if (temp.Equals(numbersCheck[j]))
                    {
                        check = true;


                    }
                }
            }

            return check;

        }

        #endregion

        #region Form Events
        private void CreateCustomerForm_Activated(object sender, EventArgs e)
        {

        }

        private void btnSubmitC_Click(object sender, EventArgs e)
        {

            bool checkPhone = checkNumbers(txtPhoneNum.Text);
            bool checkPostal = checkNumbers(txtPostalCode.Text);

            bool checkCity = checkLetters(txtTownOrCity.Text);
            bool checkProvince = checkLetters(txtProvince.Text);
            if (txtTownOrCity.Text.Equals("") || txtProvince.Text.Equals("") || txtEmail.Text.Equals("") || txtName.Text.Equals("") || txtPhoneNum.Text.Equals("") || txtPostalCode.Text.Equals("") || txtStreetA.Text.Equals("") || txtSurname.Text.Equals(""))
            {
                MessageBox.Show("Please fill all the fields");

            }
            else if (txtPostalCode.TextLength != 4 || checkPostal == true)
            {
                MessageBox.Show("Please enter a valid postal code");
            }
            else
            if (checkPhone == true || txtPhoneNum.TextLength != 10)
            {
                MessageBox.Show("Please enter a valid phone number");

            }
            else if (checkCity == true || checkProvince == true)
            {
                MessageBox.Show("Please enter a valid province or city");
            }
            else
            {
                PopulateObject();
                MessageBox.Show("Customer entered!");
                customerController.DataMaintanence(customer, Data.DB.DBOperation.Add);
                customerController.FinalizeChanges(customer);

            }

            MakeBookingForm makeBookingForm = new MakeBookingForm(txtCustID.Text, dateA, dateD);
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