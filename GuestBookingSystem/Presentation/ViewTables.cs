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
    public partial class ViewTables : Form
    { 

        private bool isOpen = false;

        public bool IsOpen
        {
            get { return isOpen; }
        }

        public ViewTables()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerDB customerDB = new CustomerDB();

            dataGridView1.DataSource = customerDB.GetDataSet();
            dataGridView1.DataMember = "Customer";
        }

        private void testForm_Load(object sender, EventArgs e)
        {
            isOpen = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void testForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen=false;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            BookingDB bookingDB = new BookingDB();

            dataGridView1.DataSource = bookingDB.GetDataSet();
            dataGridView1.DataMember = "Booking";
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            RoomDB roomDB = new RoomDB();

            dataGridView1.DataSource = roomDB.GetDataSet();
            dataGridView1.DataMember = "Room";
        }
    }
}
