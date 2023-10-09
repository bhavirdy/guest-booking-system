using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using GuestBookingSystem.Business;
using GuestBookingSystem.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GuestBookingSystem.Presentation
{
    public partial class OccupancyReport : Form
    {

        #region Data Members
        private bool isOpen = false;

        BookingController bookingC = new BookingController();

        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        #endregion

        #region Property Methods
        public bool IsOpen
        {
            get { return isOpen; }
        }
        #endregion

        #region Constructor
        public OccupancyReport()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void OccupancyReport_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //gets the total number of bookings
            int c = bookingC.bookingCount(dateArrival.Value, dateDeparture.Value);
            txtCount.Text = c.ToString();

        }


        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            BookingDB bookingDB = new BookingDB();

            //year of report
            int year = DateTime.Now.Year;

            //dict of num bookings per month
            Dictionary<string, int> bookingsPerMonth = bookingDB.GetBookingsPerMonth(year);

            chart1.Series.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Bar;

            //add data points to the series
            foreach (var kvp in bookingsPerMonth)
            {
                series.Points.Add(new DataPoint(0, kvp.Value) { AxisLabel = kvp.Key });
            }

            chart1.Series.Add(series);

            //chart title and labels
            chart1.Titles.Add("Monthly Booking Counts for " + year);
            chart1.ChartAreas[0].AxisX.Title = "Month";
            chart1.ChartAreas[0].AxisY.Title = "Booking Count";

            //refresh the chart
            chart1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion 
    }
}
