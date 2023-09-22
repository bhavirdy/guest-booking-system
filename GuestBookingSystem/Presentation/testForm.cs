using GuestBookingSystem.Business;
using GuestBookingSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestBookingSystem.Presentation
{
    public partial class testForm : Form
    {
        public testForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerDB customerDB = new CustomerDB();

            dataGridView1.DataSource = customerDB.GetDataSet();
            dataGridView1.DataMember = "Customer";
        }
    }
}
