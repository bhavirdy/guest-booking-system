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
        Collection<Booking> bookingCollection;

        #endregion

        #region Property Methods
        public Collection<Booking> BookingCollection
        {
            get { return BookingCollection; }
        }

        #endregion

        #region Constructor

        public BookingController()
        {
            bookingDB = new bookingDB();
            bookingCollection = bookingDB.AllBookings;

        }

        #endregion 

        public void DataMaintanence(Booking bookTemp)
        {
            bookingDB.DataSetChange(bookTemp);
            bookingCollection.Add(bookTemp);
        }

        public bool FinalizeChanges(Booking bookTemp)
        {
            return bookingDB.UpdateDataSource(bookTemp);
        }
    }
}
