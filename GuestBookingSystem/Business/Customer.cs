using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookingSystem.Business
{
    internal class Customer : Person
    {
        #region Data Members

        private String custID;
        private String cardNumber;
        private int bookingID;

        #endregion

        #region Constructor
        public Customer(String cardTemp) : base()
        {
            cardNumber = cardTemp;
            bookingID = 0;
        }

        public Customer()
        {

        }

        #endregion

        #region Property Members


        public String CustID
        {
            get { return custID; }
            set { custID = value; }
        }


        public String CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        public int BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }

        #endregion 
    }
}
