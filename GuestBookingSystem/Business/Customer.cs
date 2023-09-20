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
        public Customer(String nameTemp, String surnameTemp, String emailTemp, String phoneTemp, String streetAddressTemp, String townOrCityTemp, String postalCodeTemp, String countryTemp, String custIDTemp, String cardNumberTemp, int bookingIDTemp) 
            : base(nameTemp, surnameTemp, emailTemp, phoneTemp, streetAddressTemp, townOrCityTemp, postalCodeTemp, countryTemp)
        {
            cardNumber = cardNumberTemp;
            bookingID = bookingIDTemp;
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
