using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using GuestBookingSystem.Business;
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

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            //gets the total number of bookings
            int c = bookingC.bookingCount(dateArrival.Value, dateDeparture.Value);
            txtCount.Text = c.ToString();

            //displayu number of bookings for each month
            Series s = new Series();

            s.ChartType = SeriesChartType.Bar;

            int monthIndex1 = 0;
            int monthIndex2 = 0;

            //temp array to hold the names of months in between chosen dates
            string[] monthsTemp = new string[12];

            //looks for the index of the first month
            //eg: if the chosen date was April, then it will return 3
            for(int i =0; i <=11; i++)
            {
                if (dateArrival.Value.Month.ToString().Equals(months[i]))
                {
                    monthIndex1= i;
                }
            }

            //looks for the index of the first month
            //eg: if the chosen date was April, then it will return 3
            for (int i = 0; i <= 11; i++)
            {
                if (dateDeparture.Value.Month.ToString().Equals(months[i]))
                {
                    monthIndex2 = i;
                }
            }

            int monthCount = 0;
            //creating an array of the names of months to put as axis labels
            for (int y = monthIndex1 ; y <= monthIndex2; y++)
            {
                monthsTemp[monthCount] = months[y];
            }

            //getting the counts for each of the months
            int[] nums = bookingC.countMonths(monthIndex1,monthIndex2);


            //displaying the counts for each month on the chart
            for(int x =0; x< nums.Length; x++)
            {
                s.Points.Add(new DataPoint(0, nums[x]) { AxisLabel = monthsTemp[x] });
            }




        }
        #endregion

        private void chart1_Click(object sender, EventArgs e)
        {
            //get the number of bookings for each month and display 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
