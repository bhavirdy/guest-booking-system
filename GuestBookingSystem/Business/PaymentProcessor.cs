using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookingSystem.Business
{
    internal class PaymentProcessor
    {
        #region Constructor
        public PaymentProcessor() { }

        #endregion

        #region Methods
        public bool processPayment(int cardNo, double amount)
        {
            return true;
        }
        #endregion
    }
}
