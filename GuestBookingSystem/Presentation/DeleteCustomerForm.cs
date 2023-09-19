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

namespace GuestBookingSystem.Presentation
{
    public partial class DeleteCustomerForm : Form
    {
        #region Data Members
        DataSet ds = new DataSet();

        //Don't know what the connection is
        SqlConnection conDB = new SqlConnection();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();

        #endregion

        #region Constructor

        public DeleteCustomerForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Form Events

        private void DeleteCustomerForm_Load(object sender, EventArgs e)
        {

            SqlCommand sqlSelect = new SqlCommand("SELECT * FROM Customer", conDB);

            conDB.Open();
            dataAdapter.SelectCommand = sqlSelect;
            dataAdapter.Fill(ds, "Customer");
            conDB.Close();


            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Customer";


        }

        #endregion 
    }
}
