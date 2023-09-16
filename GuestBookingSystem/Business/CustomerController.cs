using GuestBookingSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookingSystem.Business
{
    internal class CustomerController
    {
        #region Data Members
        CustomerDB customerDB;
        Collection<Customer> customerCollection;

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
