using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookingSystem.Business
{
    internal class HotelBookingSystem
    {

        public HotelBookingSystem() { }

        public Booking makeBooking() { return new Booking(); }

        public bool changeBooking(Booking booking, DateTime newArriveDate, DateTime newLeaveDate) { return false; }

        public bool cancelBooking(Booking booking) { return false; }

        public bool getBookingStatus(Booking booking) { return false; }

        public bool makeBookingEnquiry(Booking booking) { return false; }


    }
}
