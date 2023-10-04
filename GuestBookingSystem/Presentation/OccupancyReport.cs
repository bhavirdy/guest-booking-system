using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuestBookingSystem.Business;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GuestBookingSystem.Presentation
{
    public partial class OccupancyReport : Form
    {

        #region Data Members
        private bool isOpen = false;

        BookingController bookingC = new BookingController();
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
            int c = bookingC.bookingCount(dateArrival.Value, dateDeparture.Value);

            txtCount.Text = c.ToString();
        }
        #endregion
    }
}
