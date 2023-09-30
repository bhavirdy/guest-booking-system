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
            MakeBookingForm makeBookingForm = new MakeBookingForm();
            makeBookingForm.MdiParent = this.MdiParent;
            makeBookingForm.Show();
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
                    var (pricePerNight, totalPrice, deposit) = CalculateRoomPricing(arriveDate, leaveDate);

                    availableRooms.Add(room);
                    richTextBox1.AppendText($"Room ID: {room.RoomID}, Num Beds: {room.NumBeds}\n");
                    richTextBox1.AppendText($"Price Per Night: {pricePerNight:C}, Total Price: {totalPrice:C}, Deposit: {deposit:C}\n");
                    richTextBox1.AppendText("\n");
                }
            }

            if (availableRooms.Count == 0)
            {
                richTextBox1.AppendText("No rooms available for the specified dates.");
            }

        }
        private (decimal PricePerNight, decimal TotalPrice, decimal Deposit) CalculateRoomPricing(DateTime arriveDate, DateTime leaveDate)
        {
            // Define seasonal rates.
            decimal lowSeasonRate = 550;
            decimal midSeasonRate = 750;
            decimal highSeasonRate = 995;

            // Define the booking deposit percentage.
            decimal depositPercentage = 0.10m;

            // Calculate the number of nights for the stay.
            int numberOfNights = (leaveDate - arriveDate).Days;

            // Determine the season based on the arrival date.
            string season;
            if (arriveDate.Month >= 1 && arriveDate.Month <= 12 && arriveDate.Day >= 1 && arriveDate.Day <= 7)
            {
                season = "Low Season";
            }
            else if (arriveDate.Month == 12 && arriveDate.Day >= 8 && arriveDate.Day <= 15)
            {
                season = "Mid Season";
            }
            else
            {
                season = "High Season";
            }

            // Calculate the price per night based on the season.
            decimal pricePerNight;
            switch (season)
            {
                case "Low Season":
                    pricePerNight = lowSeasonRate;
                    break;
                case "Mid Season":
                    pricePerNight = midSeasonRate;
                    break;
                case "High Season":
                    pricePerNight = highSeasonRate;
                    break;
                default:
                    // Handle an invalid season here if needed.
                    pricePerNight = 0;
                    break;
            }

            // Calculate the total price for the stay.
            decimal totalPrice = pricePerNight * numberOfNights;

            // Calculate the booking deposit.
            decimal deposit = totalPrice * depositPercentage;

            return (pricePerNight, totalPrice, deposit);
        }
    }
}
