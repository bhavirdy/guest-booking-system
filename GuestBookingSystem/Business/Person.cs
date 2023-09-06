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
        private String country;
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

        public String Country
        {
            get { return country; }
            set { country = value; }
        }

        #endregion

        #region Constructor

        public Person(String nTemp, String sTemp, String eTemp, String cTemp, String pTemp)
        {
            name = nTemp;
            surname = sTemp;
            email = eTemp;
            country = cTemp;
            phone = pTemp;
       
        }

        #endregion 
    }
}
