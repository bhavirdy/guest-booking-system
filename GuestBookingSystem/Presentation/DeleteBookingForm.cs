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
    public partial class DeleteBookingForm : Form
    {
        #region Data Members
        DataSet ds = new DataSet();

        //I don't know what the sql connection is
        SqlConnection conDB = new SqlConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();

        private bool isOpen = false;

        public bool IsOpen
        {
            get { return isOpen; }
            set { isOpen = value; }
        }

        #endregion

        #region Constructor
        public DeleteBookingForm()
        {
            InitializeComponent();
            isOpen = true;
        }

        #endregion

        #region Form Events

        private void lblHeadingEdit_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBookingForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            //SqlCommand sqlSelect = new SqlCommand("SELECT * FROM Booking", conDB);

            //conDB.Open();
            //adapter.SelectCommand = sqlSelect;
            //adapter.Fill(ds, "Booking");
            //conDB.Close();


            //dataGridView1.DataSource = ds;
            //dataGridView1.DataMember = "Booking";

        }

        #endregion

        private void DeleteBookingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
        }
    }
}
