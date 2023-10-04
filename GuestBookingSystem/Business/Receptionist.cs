using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookingSystem.Business
{
    internal class Receptionist : Person
    {

        #region Data Members
        private int recpNum;
        #endregion

        #region Property Members

        public int ReceptionistNum
        {
            get { return recpNum; }
            set { recpNum = value; }
        }

        #endregion

        #region Constructor
        public Receptionist(String nameTemp, String surnameTemp, String emailTemp, String phoneTemp, String streetAddressTemp, String townOrCityTemp, String postalCodeTemp, String countryTemp, int rNum) 
            : base(nameTemp, surnameTemp, emailTemp, phoneTemp, streetAddressTemp, townOrCityTemp, postalCodeTemp, countryTemp)
        {
            this.recpNum = rNum;
        }

        #endregion 

    }
}
