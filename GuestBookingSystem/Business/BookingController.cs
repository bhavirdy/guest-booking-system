using GuestBookingSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookingSystem.Data;

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
                    index = FindIndex(bookingTemp);
                    bookings.Insert(index, bookingTemp);
                    break;
            }

            //perform a given database operation

        }

        public bool FinalizeChanges(Booking bookingTemp)
        {
            return bookingDB.UpdateDataSource(bookingTemp);
        }

        #endregion

        #region Search Methods

        public Booking Find(int ID)
        {
            int index = 0;
            bool found = (bookings[index].BookingID == ID);
            int count = bookings.Count;

            while (!(found) && (index < bookings.Count - 1))
            {
                index = index + 1;
                found = (bookings[index].BookingID == ID);

                
            }

            return bookings[index];
        }

        public int FindIndex(Booking bookTemp)
        {
            int counter = 0;
            bool found = false;
            found = (bookTemp.BookingID == bookings[counter].BookingID);
            while(found == false && counter < bookings.Count)
            {
                found = (bookTemp.BookingID == bookings[counter].BookingID);

            }

            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }

        #endregion 



    }
}
