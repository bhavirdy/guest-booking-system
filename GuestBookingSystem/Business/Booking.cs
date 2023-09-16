using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookingSystem.Business
{
    internal class Booking
    {
        #region Data Members
        private int customerID;
        private DateTime arriveDate;
        private DateTime leaveDate;
        private int roomNumber;
        private double deposit;
        private double totalPrice;

        #endregion

        #region Property Members
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public DateTime ArriveDate
        {
            get { return arriveDate; }
            set { arriveDate = value; }
        }

        public DateTime LeaveDate
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


        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        #endregion

        #region Constructor

        public Booking()
        {

        }

        public Booking(int custTemp, String aDate, String lDate, int rNum, double dTemp, double pricePerNightTemp, double totalPriceTemp)
        {
            customerID = custTemp;
            arriveDate = aDate;
            leaveDate = lDate;
            roomNumber = rNum;
            deposit = dTemp;
            pricePerNight = pricePerNightTemp;
            totalPrice = totalPriceTemp;
        }

        #endregion 


    }
}
