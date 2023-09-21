using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookingSystem.Business
{
    internal class Person
    {
        #region Data Member
        private String name;
        private String surname;
        private String email;
        private String streetAddress;
        private String townOrCity;
        private String province;
        private String postalCode;
        private String phone;

        #endregion

        #region Property Members

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public String Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public String Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }

        public String TownOrCity
        {
            get { return townOrCity; }
            set { townOrCity = value; }

        }

        public String Province
        {
            get { return province; }
            set { province = value; }
        }

        public String PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        #endregion

        #region Constructor

        public Person(String nameTemp, String surnameTemp, String emailTemp, String phoneTemp, String streetAddressTemp, String townOrCityTemp, String postalCodeTemp, String provinceTemp)
        {
            name = nameTemp;
            surname = surnameTemp;
            email = emailTemp;
            phone = phoneTemp;
            streetAddress = streetAddressTemp;
            townOrCity = townOrCityTemp;
            postalCode = postalCodeTemp;
            province = provinceTemp;
        }

        #endregion 
    }
}
