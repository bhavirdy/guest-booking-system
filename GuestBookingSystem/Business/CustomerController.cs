using GuestBookingSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookingSystem.Business
{
    public class CustomerController
    {
        #region Data Members
        private CustomerDB customerDB;
        private Collection<Customer> customerCollection;
        #endregion

        #region Property Methods
        public Collection<Customer> CustomerCollection
        {
            get { return customerCollection; }
        }

        #endregion

        #region Constructor

        public CustomerController()
        {
            customerDB = new CustomerDB();
            customerCollection = customerDB.AllCustomers;
        }

        #endregion

        #region Search Methods

        public Customer Find(String ID)
        {
            int index = 0;
            bool found = (customerCollection[index].CustID == ID);
            int count = customerCollection.Count;
            while(!(found) && (index < customerCollection.Count - 1))
            {
                index = index + 1;
                found = (customerCollection[index].CustID == ID);

            }

            return customerCollection[index];
        }

        public int FindIndex(Customer custTemp)
        {
            int count = 0;
            bool found = false;
            found = (custTemp.CustID == customerCollection[count].CustID);
            while(found == false && count < customerCollection.Count)
            {
                found = (custTemp.CustID == customerCollection[count].CustID);

            }

            if (found)
            {
                return count;
            }
            else
            {
                return -1;
            }
        }

        #endregion 

        #region DataBase Communication

        public void DataMaintanence(Customer custTemp)
        {
            customerDB.DataSetChange(custTemp);
            customerCollection.Add(custTemp);
        }



        public bool FinalizeChanges(Customer custTemp)
        {
            return customerDB.UpdateDataSource(custTemp);
        }

        #endregion
    }
}
