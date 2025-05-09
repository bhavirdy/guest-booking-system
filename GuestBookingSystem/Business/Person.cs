﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookingSystem.Business
{
    public class Person
    {
        #region Data Members
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

        #region Constructors
        public Person()
        { }

        #endregion 
    }
}
