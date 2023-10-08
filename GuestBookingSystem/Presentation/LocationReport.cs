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
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace GuestBookingSystem.Presentation
{
    public partial class LocationReport : Form
    {
        #region Data Members
        private bool isOpen = false;

        CustomerController customerC = new CustomerController();
        #endregion

        #region Property Methods
        public bool IsOpen
        {
            get { return isOpen; }
        }
        #endregion

        #region Constructor
        public LocationReport()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numCustEC = customerC.countCustomers("EC");
            int numCustFS = customerC.countCustomers("Free State");
            int numCustG = customerC.countCustomers("Gauteng");
            int numCustKZN = customerC.countCustomers("KZN");
            int numCustL = customerC.countCustomers("Limpopo");
            int numCustM = customerC.countCustomers("Mpumalanga");
            int numCustNW = customerC.countCustomers("North West");
            int numCustNC = customerC.countCustomers("Northen Cape");
            int numCustWC = customerC.countCustomers("WC");

            // Create a series
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;

            // Add data points to the series
            series.Points.Add(new DataPoint(0, numCustEC) { AxisLabel = "EC" });
            series.Points.Add(new DataPoint(1, numCustFS) { AxisLabel = "Free State" });
            series.Points.Add(new DataPoint(2, numCustG) { AxisLabel = "Gauteng" });
            series.Points.Add(new DataPoint(3, numCustKZN) { AxisLabel = "KZN" });
            series.Points.Add(new DataPoint(4, numCustL) { AxisLabel = "Limpopo" });
            series.Points.Add(new DataPoint(5, numCustNW) { AxisLabel = "North West" });
            series.Points.Add(new DataPoint(6, numCustM) { AxisLabel = "Mpumalanga" });
            series.Points.Add(new DataPoint(7, numCustNC) { AxisLabel = "Northen Cape" });
            series.Points.Add(new DataPoint(8, numCustWC) { AxisLabel = "WC" });

            // Add the series to the chart
            chart1.Series.Clear(); // Clear existing series (if any)
            chart1.Series.Add(series);

        }

        private void LocationReport_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        #endregion
    }
}
