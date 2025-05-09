﻿using System;
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
        private String cardNumber;
        private Boolean paid;
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
        public String CardNumber
        {
            set { cardNumber = value; }
            get { return cardNumber; }
        }
        public Boolean Paid
        {
            set { paid = value; }
            get { return paid; }
        }

        public double PricePerNight
        {
            get { return pricePerNight; }
            set { pricePerNight = value; }

        }
        #endregion

        #region Constructor

        //default constructor
        public Booking()
        {

        }
        #endregion

        #region Methods
        public void setPricePerNight()
        {
            //calculates pricePerNight: does not take into account if a booking is partially in multiple different seasons eg: in both low and mid season
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

        public void setTotalPrice()
        {
            //calculates totalPrice: does not take into account if a booking is partially in multiple different seasons eg: in both low and mid season
            TimeSpan stayDuration = leaveDate - arriveDate;
            int numberOfNights = stayDuration.Days;

            if (numberOfNights < 0)
            {
                throw new ArgumentException("Invalid dates. Departure date must be after arrival date.");
            }

            totalPrice = numberOfNights * pricePerNight;

        }

        public void setDeposit()
        {
            //calculates deposit
            deposit = 0.1 * totalPrice;
        }
        #endregion
    }
}