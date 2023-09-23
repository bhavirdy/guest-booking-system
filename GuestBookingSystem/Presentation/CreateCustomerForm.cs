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

        private Customer customer;
        private CustomerController customerController;
        public bool customerFormClosed = false;


        private bool isOpen = false;

        #endregion

        #region Constructor

        public CreateCustomerForm(CustomerController controllerTemp)
        {
            InitializeComponent();
            customerController = controllerTemp;
            isOpen = true;
        }

        #endregion


        private void CreateCustomerForm_Activated(object sender, EventArgs e)
        {

        }

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
        }

        #endregion

        #region Form Events
        private void btnSubmitC_Click(object sender, EventArgs e)
        {

            if (txtTownOrCity.Text.Equals("") || txtProvince.Text.Equals("") || txtEmail.Text.Equals("") || txtName.Text.Equals("") || txtPhoneNum.Text.Equals("") || txtPostalCode.Text.Equals("") || txtStreetA.Text.Equals("") || txtSurname.Text.Equals(""))
            {
                MessageBox.Show("Please fill all the fields");

            }
            else if (txtPostalCode.TextLength != 4) 
            { 
                MessageBox.Show("Please enter a valid postal code"); 
            }
        
    
        //else
        //{
        //    PopulateObject();

        //    SqlCommand commIns = new SqlCommand("INSERT INTO Customer(CustomerID, Name, Surname, Email, StreetAddress, Town, PostalCode, Phone" +
        //                                           "VALUES(@CustomerID, @Name, @Surname, @Email, @StreetAddress, @Town, @PostalCode, @Phone", conDB);

        //    commIns.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 50, "CustomerID").Value = txtCustID.Text;
        //    commIns.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name").Value = txtName.Text;
        //    commIns.Parameters.Add("@Surname", SqlDbType.NVarChar, 50, "Surname").Value = txtSurname.Text;
        //    commIns.Parameters.Add("@Email", SqlDbType.NVarChar, 50, "Email").Value = txtEmail.Text;
        //    commIns.Parameters.Add("@StreetAddress", SqlDbType.NVarChar, 50, "StreetAddress").Value = txtStreetA.Text;
        //    //commIns.Parameters.Add("@Suburb", SqlDbType.NVarChar, 50, "Suburb").Value = txtSuburb.Text;
        //    commIns.Parameters.Add("@Town", SqlDbType.NVarChar, 50, "Town").Value = txtCity.Text;
        //    commIns.Parameters.Add("@Country", SqlDbType.NVarChar, 50, "Country").Value = txtCountry.Text;
        //    commIns.Parameters.Add("@PostalCode", SqlDbType.NVarChar, 50, "PostalCode").Value = txtPostalCode.Text;
        //    commIns.Parameters.Add("@Phone", SqlDbType.NVarChar, 50, "Phone").Value = txtPhoneNum.Text;

        //    commIns.ExecuteNonQuery();



        //    MessageBox.Show("Customer entered!");
        //    customerController.DataMaintanence(customer);
        //    customerController.FinalizeChanges(customer);
        //    ClearAll();
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
            this.isOpen = false;
            this.Close();
        }
    }
    #endregion

}