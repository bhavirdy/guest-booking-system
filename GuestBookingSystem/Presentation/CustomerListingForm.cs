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
        }

        private void CustomerListingForm_Load(object sender, EventArgs e)
        {
            customerListView.View = View.Details;
        }

        private void setUpCustomerListView()
        {
            ListViewItem customerDetails;
            //Customer customer;
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

            customers = null;

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
            //if ((state == FormStates.Edit) && value)
            //{
            //    idTextBox.Enabled = !value;
            //    empIDTextBox.Enabled = !value;
            //}
            //else
            //{
            //    idTextBox.Enabled = value;
            //    empIDTextBox.Enabled = value;
            //}
            //nameTextBox.Enabled = value;
            //phoneTextBox.Enabled = value;
            //paymentTextBox.Enabled = value;
            //shiftsTextBox.Enabled = value;
            //if (state == FormStates.Delete)
            //{
            //    cancelButton.Visible = !value;
            //    submitButton.Visible = !value;
            //}
            //else
            //{
            //    cancelButton.Visible = value;
            //    submitButton.Visible = value;
            //}

        }



        private void PopulateTextBoxes(Customer customerTemp)
        {

            //idTextBox.Text = employee.ID;
            //empIDTextBox.Text = employee.EmployeeID;
            //nameTextBox.Text = employee.Name;
            //phoneTextBox.Text = employee.Telephone;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //PopulateObject();

            if (state == FormStates.Edit)
            {
                customerController.DataMaintanence(customer, Data.DB.DBOperation.Add);
            }
            else
            {
                customerController.DataMaintanence(customer, Data.DB.DBOperation.Delete);
            }

            customerController.FinalizeChanges(customer);
            //ClearAll();
            state = FormStates.View;
            setUpCustomerListView();

        }

        private void PopulateObject()
        {
            //employee = new Employee(roleType);
            //employee.ID = idTextBox.Text;
            //employee.EmployeeID = empIDTextBox.Text;
            //employee.Name = nameTextBox.Text;
            //employee.Telephone = phoneTextBox.Text;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Red;
            state = FormStates.Delete;
        }
    }
}
