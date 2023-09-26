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

namespace GuestBookingSystem.Presentation
{
    public partial class CustomerListingForm : Form
    {
        
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

        public bool IsOpen
        {
            get { return isOpen; }
        }
        
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

        private void EnableEntries(bool value)
        {
            if ((state == FormStates.Edit) && value)
            {
                txtCustomerID.Enabled = !value;
                txtName.Enabled = value;
                txtSurname.Enabled = value;
                txtPhone.Enabled = value;
                txtStreetAddress.Enabled = value;
                txtTownOrCity.Enabled = value;
                txtProvince.Enabled = value;
                txtPostalCode.Enabled = value;
                txtEmail.Enabled = value;
            }

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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            PopulateObject();

            if (state == FormStates.Edit)
            {
                customerController.DataMaintanence(customer, Data.DB.DBOperation.Add);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            state = FormStates.Delete;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            state = FormStates.Edit;
            EnableEntries(true);
        }
    }
}
