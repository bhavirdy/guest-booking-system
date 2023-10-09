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

        #endregion

        #region Constructors
        //default constructor
        public Customer()
        { }

        #endregion

        #region Property Members

        public String CustID
        {
            get { return custID; }
            set { custID = value; }
        }
        #endregion 
    }
}
