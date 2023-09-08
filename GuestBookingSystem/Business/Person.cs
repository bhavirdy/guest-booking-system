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
        private String streetAdress;
        private String city;
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

        public String City
        {
            get { return city; }
            set { city = value; }

        }

        public String PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }

        #endregion

        #region Constructor

        public Person(String nTemp, String sTemp, String eTemp, String pTemp, String streetTemp, String postalTemp, String cityTemp)
        {
            name = nTemp;
            surname = sTemp;
            email = eTemp;
            phone = pTemp;
            city = cityTemp;
            postalCode = postalTemp;
            streetAdress = streetTemp;
       
        }

        #endregion 
    }
}
