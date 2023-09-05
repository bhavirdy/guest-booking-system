using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookingSystem.Business
{
    internal class Customer
    {
        #region Instance Variables
        private String name;
        private String surname;
        private int custID;
        private String phone;
        private String email;
        private String country;
        private String cardNumber;

        #endregion

        #region Constructor
        public Customer() {
        }

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

        public int CustID
        {
            get { return custID; }
            set { custID = value; }
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

        public String CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        #endregion 
    }
