using GuestBookingSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestBookingSystem.Presentation
{
    public partial class EditCustomerForm : Form
    {
        #region Data Members
        private Customer customer;
        private CustomerController custController;
        private Collection<Customer> customers;
        private bool isOpen = false;

        DataSet ds = new DataSet();
        //idk where our database is located
        SqlConnection conDB = new SqlConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();

        #endregion

        #region Property Members

        public bool IsOpen
        {
            get { return isOpen; }
            set { isOpen = value; }

        }

        #endregion 

        #region Constructor
        public EditCustomerForm()
        {
            InitializeComponent();
            //this.Load += EditCustomersForm_Load;
            //this.Activated += EditCustomersForm_Activated;
            isOpen = true;
        }

        private void EditCustomersForm_Activated(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //public EditCustomersForm(CustomerController custController)
        //{
        //    InitializeComponent();
        //    this.custController = custController;
        //    this.Load += EditCustomersForm_Load;
        //    this.Activated += EditCustomersForm_Activated;
        //    this.FormClosed += EditCustomersForm_FormClosed1;
        //    isOpen = true;

        //}

        private void EditCustomersForm_FormClosed1(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Events

        public void EditCustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
        }

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            this.WindowState = FormWindowState.Maximized;
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

            foreach (Customer customer in customers)
            {
                customerDetails = new ListViewItem();
                customerDetails.Text = customer.CustID.ToString();
                customerDetails.SubItems.Add(customer.CustID.ToString());
                customerDetails.SubItems.Add(customer.Name.ToString());
                customerDetails.SubItems.Add(customer.Surname.ToString());
                customerDetails.SubItems.Add(customer.Email.ToString());
                customerDetails.SubItems.Add(customer.TownOrCity.ToString());
                //customerDetails.SubItems.Add(customer.Suburb.ToString());
                customerDetails.SubItems.Add(customer.PostalCode.ToString());
                customerDetails.SubItems.Add(customer.Phone.ToString());
                //customerDetails.SubItems.Add(customer.CardNumber.ToString());

                listView1.Items.Add(customerDetails);
            }


            listView1.Refresh();
            listView1.GridLines = true;
        }

        #endregion 

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (listView1.SelectedItems.Count > 0)
            {
                customer = custController.Find(int.Parse(listView1.SelectedItems[0].Text));
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

        private void PopulateTextBoxes(Customer custTemp)
        {
            txtSurname.Text = custTemp.Surname;
            //txtSuburb.Text = custTemp.Suburb;
            txtStreetA.Text = custTemp.StreetAddress;
            txtPostalCode.Text = custTemp.PostalCode;
            txtPhoneNumber.Text = custTemp.Phone;
            txtName.Text = custTemp.Name;
            txtEmail.Text = custTemp.Email;
            txtCountry.Text = custTemp.Province;
            txtCity.Text = custTemp.TownOrCity;
            //txtCardNumber.Text = custTemp.CardNumber;
        }

        private Customer PopulateObject()
        {
            //customer = new Customer();
            //customer.CardNumber = txtCardNumber.Text;
            customer.Surname = txtSurname.Text;
            customer.StreetAddress = txtStreetA.Text;
            customer.Email = txtEmail.Text;
            customer.Province = txtCountry.Text;
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
            EditCustomerForm.ActiveForm.Close();
        }

        private void btnClearEditC_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnCancelEditC_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
