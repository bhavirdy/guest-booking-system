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
            int numCustEC = customerC.countCustomers("Eastern Cape");
            int numCustFS = customerC.countCustomers("Free State");
            int numCustG = customerC.countCustomers("Gauteng");
            int numCustKZN = customerC.countCustomers("KwaZulu-Natal");
            int numCustL = customerC.countCustomers("Limpopo");
            int numCustM = customerC.countCustomers("Mpumalanga");
            int numCustNW = customerC.countCustomers("North West");
            int numCustNC = customerC.countCustomers("Northen Cape");
            int numCustWC = customerC.countCustomers("Western Cape");
            
            chart1.Series["Customer Count"].ChartType = SeriesChartType.Column;
            Series s = new Series();

            s.ChartType = SeriesChartType.Column;

            s.Points.Add(new DataPoint(0, numCustEC) { AxisLabel = "Eastern Cape" });
            s.Points.Add(new DataPoint(1, numCustFS) { AxisLabel = "Free State" });
            s.Points.Add(new DataPoint(2, numCustG) { AxisLabel = "Gauteng" });
            s.Points.Add(new DataPoint(3, numCustKZN) { AxisLabel = "KwaZulu-Natal" });
            s.Points.Add(new DataPoint(4, numCustL) { AxisLabel = "Limpopo" });
            s.Points.Add(new DataPoint(5, numCustNW) { AxisLabel = "North West" });
            s.Points.Add(new DataPoint(6, numCustM) { AxisLabel = "Mpumalanga" });
            s.Points.Add(new DataPoint(7, numCustNC) { AxisLabel = "Northen Cape" });
            s.Points.Add(new DataPoint(8, numCustWC) { AxisLabel = "Western Cape" });
           
        }

        private void LocationReport_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
