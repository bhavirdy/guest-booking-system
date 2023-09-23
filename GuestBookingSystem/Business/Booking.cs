using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace GuestBookingSystem.Business
{
    public class Booking
    {
        #region Data Members
        private String bookingID;
        private String customerID;
        private DateTime arriveDate;
        private DateTime leaveDate;
        private int roomNumber;
        private int cardNumber;
        private String paid;

        private double deposit;
        private double totalPrice;
        private double pricePerNight;

        private DateTime midSeasonStartDate = new DateTime(2023, 12, 8);
        private DateTime midSeasonEndDate = new DateTime(2023, 12, 15);
        private DateTime highSeasonStartDate = new DateTime(2023, 12, 16);
        private DateTime highSeasonEndDate = new DateTime(2023, 12, 31);

        #endregion

        #region Property Members
        public String CustomerID
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


        public String BookingID
        {
            get { return bookingID; }

            set { bookingID = value; }
        }
        public int CardNumber
        {
            set { cardNumber = value; }
            get { return cardNumber; }
        }

        public String Paid
        {
            set { Paid = value; }
            get { return paid; }
        }

        public double PricePerNight
        {
            get { return pricePerNight; }
            set { pricePerNight = value; }

        }

        #endregion

        #region Constructor

        public Booking()
        {

        }

        public Booking(String custTemp, DateTime aDate, DateTime lDate, int rNum)

        {
            customerID = custTemp;
            arriveDate = aDate;
            leaveDate = lDate;
            roomNumber = rNum;
            this.setPricePerNight();
            this.setTotalPrice();
            this.setDeposit();
        }

        #endregion

        #region methods

        private void setPricePerNight()
        {
            //determine pricePerNight -- does not take into account if a booking is partially in multiple different seasons eg: in both low and mid season
            if (arriveDate >= highSeasonStartDate && arriveDate <= highSeasonEndDate)
            {
                pricePerNight = 995;
            }
            else if (arriveDate >= midSeasonStartDate && arriveDate <= midSeasonEndDate)
            {
                pricePerNight = 750;
            }
            else
            {
                pricePerNight = 550;
            }
        }

        private void setTotalPrice()
        {
            //determine totalPrice -- does not take into account if a booking is partially in multiple different seasons eg: in both low and mid season
            TimeSpan stayDuration = leaveDate - arriveDate;
            int numberOfNights = stayDuration.Days;

            if (numberOfNights < 0)
            {
                // Handle invalid date range
                throw new ArgumentException("Invalid date range. Departure date must be after arrival date.");
            }

            totalPrice = numberOfNights * pricePerNight;

        }

        private void setDeposit()
        {
            //determine deposit
            deposit = 0.1 * totalPrice;
        }


        public bool updateDates(DateTime newArriveDate, DateTime newLeaveDate)
        {
            this.ArriveDate = newArriveDate;
            this.LeaveDate = newLeaveDate;
            return true;
        }

        public bool cancel()
        { return false; }

        public bool isCancelled()
        {
            return false;
        }

        public bool getStatus()
        {
            return false;
        }

        public bool confirmBooking()
        {
            return false;
        }
        #endregion

    }

}