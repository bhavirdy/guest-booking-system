using GuestBookingSystem.Business;
using GuestBookingSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestBookingSystem.Presentation
{
    public partial class CheckAvailability : Form
    {
        private bool isOpen = false;
        private CustomerController customerController;

        public bool IsOpen
        {
            get { return isOpen; }
        }

        public CheckAvailability()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateCustomerForm createCustomerForm = new CreateCustomerForm(customerController);
            createCustomerForm.MdiParent = this.MdiParent;
            createCustomerForm.Show();
        }

        private void CheckAvailability_Load(object sender, EventArgs e)
        {
            isOpen = true;
        }

        private void CheckAvailability_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            isOpen = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            RoomDB roomDB = new RoomDB();
            BookingDB bookingDB = new BookingDB();

            Collection<Room> rooms = roomDB.Rooms;

            DateTime arriveDate = dateTimePicker1.Value;
            DateTime leaveDate = dateTimePicker2.Value;

            Collection<Room> availableRooms = new Collection<Room>();

            foreach (Room room in rooms)
            {
                bool isAvailable = bookingDB.IsRoomAvailable(room.RoomID, arriveDate, leaveDate);

                if (isAvailable)
                {
                    availableRooms.Add(room);
                    richTextBox1.AppendText($"Room ID: {room.RoomID}, Num Beds: {room.NumBeds}\n");
                }
            }

        }
    }
}
