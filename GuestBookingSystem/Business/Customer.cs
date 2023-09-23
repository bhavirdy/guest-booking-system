using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookingSystem.Business
{
    public class Customer : Person
    {
        #region Data Members

        private String custID;
        private String cardNumber;

        #endregion

        #region Constructor

        public Customer()
        { }

        public Customer(String nameTemp, String surnameTemp, String emailTemp, String phoneTemp, String streetAddressTemp, String townOrCityTemp, String postalCodeTemp, String provinceTemp, String custIDTemp, String cardNumberTemp, int bookingIDTemp) 
            : base(nameTemp, surnameTemp, emailTemp, phoneTemp, streetAddressTemp, townOrCityTemp, postalCodeTemp, provinceTemp)
        {
            custID = custIDTemp;
            cardNumber = cardNumberTemp;
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

        #endregion 
    }
}
