using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookingSystem.Business
{
    internal class Customer : Person
    {
        #region Instance Variables
        
        private int custID;
        private String cardNumber;

        #endregion

        #region Constructor
        public Customer(String cardTemp) : base() {
            cardNumber = cardTemp;
        }

        #endregion

        #region Property Members
       

        public int CustID
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
