using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookingSystem.Business
{
    internal class Booking
    {
        #region Data Members
        private int customerID;
        private String arriveDate;
        private String leaveDate;
        private int roomNumber;
        private double deposit;

        #endregion

        #region Property Members
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public String ArriveDate
        {
            get { return arriveDate; }
            set { arriveDate = value; }
        }

        public String LeaveDate
        {
            get { return leaveDate; }
            set { leaveDate = value; }
        }

        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        public double Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }

        #endregion

        #region Constructor

        public Booking(int custTemp, String aDate, String lDate, int rNum, double dTemp)
        {
            customerID = custTemp;
            arriveDate = aDate;
            leaveDate = lDate;
            roomNumber = rNum;
            deposit = dTemp;
        }

        #endregion 


    }
}
