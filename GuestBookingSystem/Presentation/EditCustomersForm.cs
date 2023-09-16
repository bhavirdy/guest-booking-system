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
using GuestBookingSystem.Business;

namespace GuestBookingSystem.Presentation
{
    public partial class EditCustomersForm : Form
    {

        #region Data Members
        private Customer customer;
        private CustomerController custController;
        public bool listFormClosed;
        private Collection<Customer> customers;

        #endregion

        #region Constructor
        public EditCustomersForm()
        {
            InitializeComponent();
            this.Load += EditCustomersForm_Load;
            this.Activated += EditCustomersForm_Activated;
        }

        public EditCustomersForm(CustomerController custController)
        {
            InitializeComponent();
            this.custController = custController;
            this.Load += EditCustomersForm_Load;
            this.Activated += EditCustomersForm_Activated;
            this.FormClosed += EditCustomersForm_FormClosed1;

        }

        private void EditCustomersForm_FormClosed1(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Events

        public void EditCustomersForm_FormClosed(object  sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }

        private void EditCustomersForm_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void EditCustomerForm_Activated(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            setUpCustomerListView();
            ClearAll();
        }

        #endregion


        #region ListView set up

        public void setUpCustomerListView()
        {
            ListViewItem customerDetails = new ListViewItem();
            customers = null;
            listView1.Clear();

            listView1.Columns.Insert(0, "CustomerID", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(1, "Name", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(2, "Surname", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(3, "Email", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(4, "StreetAddress", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(5, "TownOrCity", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(6, "Country");
            listView1.Columns.Insert(7, "PostalCode", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(8, "Phone", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(9, "CardNumber", 120, HorizontalAlignment.Left);

            foreach(Customer customer in customers)
            {
                customerDetails = new ListViewItem();
                customerDetails.Text = customer.CustID.ToString();
                customerDetails.SubItems.Add(customer.CustID.ToString());
                customerDetails.SubItems.Add(customer.Name.ToString());
                customerDetails.SubItems.Add(customer.Surname.ToString());
                customerDetails.SubItems.Add(customer.Email.ToString());
                customerDetails.SubItems.Add(customer.TownOrCity.ToString());
                customerDetails.SubItems.Add(customer.Suburb.ToString());
                customerDetails.SubItems.Add(customer.PostalCode.ToString());
                customerDetails.SubItems.Add(customer.Phone.ToString());
                customerDetails.SubItems.Add(customer.CardNumber.ToString());

            }

            listView1.Items.Add(customerDetails);
            listView1.Refresh();
            listView1.GridLines = true;
        }

        #endregion 

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if(listView1.SelectedItems.Count > 0)
            {
                customer = custController.Find(listView1);
                PopulateTextBoxes(customer);
            }
        }

        #region Utility Methods

        private void ClearAll()
        {
            txtCardNumber.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            txtPostalCode.Text = "";
            txtStreetA.Text = "";
            txtSuburb.Text = "";
            txtSurname.Text = "";
        }

        public void PopulateTextBoxes(Customer custTemp)
        {
            txtSurname.Text = custTemp.Surname;
            txtSuburb.Text= custTemp.Suburb;
            txtStreetA.Text = custTemp.StreetAddress;
            txtPostalCode.Text = custTemp.PostalCode;
            txtPhoneNumber.Text = custTemp.Phone;
            txtName.Text = custTemp.Name;
            txtEmail.Text= custTemp.Email;
            txtCountry.Text = custTemp.Country;
            txtCity.Text = custTemp.TownOrCity;
            txtCardNumber.Text= custTemp.CardNumber;
        }

        public Customer PopulateObject()
        {
            customer = new Customer();
            customer.Suburb = txtSuburb.Text;
            customer.CardNumber = txtCardNumber.Text;
            customer.Surname = txtSurname.Text;
            customer.StreetAddress = txtStreetA.Text;
            customer.Email = txtEmail.Text;
            customer.Country = txtCountry.Text;
            customer.Name = txtName.Text;
            customer.TownOrCity = txtCity.Text;
            customer.PostalCode = txtPostalCode.Text;

            return customer;


        }


        private void lblHeadingEditC_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmitEditC_Click(object sender, EventArgs e)
        {
            PopulateObject();

            custController.DataMaintanence(customer);
            custController.FinalizeChanges(customer);
            ClearAll();
            setUpCustomerListView();

        }

        #endregion

        private void btnCancelEditC_Click(object sender, EventArgs e)
        {
            EditCustomersForm.ActiveForm.Close();
        }
    }
}
