using GuestBookingSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookingSystem.Data;
using System.Data.SqlClient;
using System.Collections.Concurrent;

namespace GuestBookingSystem.Business
{
    public class BookingController
    {
        #region Data Members

        BookingDB bookingDB;
        Collection<Booking> bookings;

        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        #endregion

        #region Property Members
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

        #region Database Communication


        public void DataMaintanence(Booking bookingTemp, DB.DBOperation operation)
        {
            int index = 0;
            bookingDB.DataSetChange(bookingTemp, operation);

            switch (operation)
            {
                case DB.DBOperation.Add:
                    bookings.Add(bookingTemp);
                    break;

                case DB.DBOperation.Edit:
                    index = FindIndex(bookingTemp);
                    bookings.RemoveAt(index);
                    bookings[index] = bookingTemp;
                    break;

                case DB.DBOperation.Delete:
                    index = FindIndex(bookingTemp);
                    bookings.RemoveAt(index);
                    break;
            }
        }

        public bool FinalizeChanges(Booking bookingTemp)
        {
            return bookingDB.UpdateDataSource(bookingTemp);
        }
        public String getUniqueBookingID()
        {
            return bookingDB.GenerateUniqueBookingID();
        }

        public int getFirstAvailableRoom(DateTime arriveDate, DateTime leaveDate)
        {
            return bookingDB.FindFirstAvailableRoom(arriveDate, leaveDate);
        }
        #endregion

        #region Search Methods

        //finds the relevant booking given the ID
        public Booking Find(String ID)
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

        //finds the index of the booking in the bookings array
        public int FindIndex(Booking bookTemp)
        {
            int count = 0;
            bool found = false;

            while (count < bookings.Count)
            {
                if (bookTemp.BookingID == bookings[count].BookingID)
                {
                    found = true;
                    break; // Exit the loop if a match is found
                }

                count++;
            }

            if (found)
            {
                return count;
            }
            else
            {
                return -1;
            }
        }

        //method for occupancy report to count the number of bookings for specified dates
        public int bookingCount(DateTime first, DateTime second)
        {

            int count = 0;
            int index = 0;
            while (index < bookings.Count)
            {
                if ((bookings[index].LeaveDate <= second) && (bookings[index].ArriveDate >= first))
                {
                    count = count + 1;
                }
                index++;
            }
            return count;
        }

        #endregion
    }
}
