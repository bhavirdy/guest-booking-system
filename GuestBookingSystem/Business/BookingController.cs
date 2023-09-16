using GuestBookingSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookingSystem.Business
{
    internal class BookingController
    {

        #region Data Members
        BookingDB bookingDB;
        Collection<Booking> bookings;   

        public Collection<Booking> Bookings
        {
            get { return bookings; }
        }

        #endregion

        #region Constructor

        public BookingController()
        {
            bookingDB = new BookingDB();
            bookings = bookingDB.AllBookings;
        }

        #endregion
        #region Databse Communication

        public void DataMaintanence(Booking bookingTemp, DB.DBOperation opp)
        {
            int index = 0;
            bookingDB.DataSetChange(bookingTemp, opp);
            switch (opp)
            {
                case DB.DBOperation.Add:
                    bookings.Add(bookingTemp);
                    break;

                case DB.DBOperation.Edit:
                    index = FindIndex(bookingTemp);
                    bookings.Insert(index, bookingTemp);
                    break;

                case DB.DBOperation.Delete:

            }

        }

    }
}
