using GuestBookingSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
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

            while (count < customerCollection.Count)
            {
                if (custTemp.CustID == customerCollection[count].CustID)
                {
                    found = true;
                    break; // Exit the loop if a match is found
                }

                count++;
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

        public void DataMaintanence(Customer custTemp, DB.DBOperation operation)
        {
            int index = 0;
            customerDB.DataSetChange(custTemp, operation);

            switch (operation)
            {
                case DB.DBOperation.Add:
                    customerCollection.Add(custTemp);
                    break;

                case DB.DBOperation.Edit:
                    index = FindIndex(custTemp);
                    customerCollection.RemoveAt(index);
                    customerCollection[index] = custTemp;
                    break;

                case DB.DBOperation.Delete:
                    index = FindIndex(custTemp);
                    customerCollection.RemoveAt(index);
                    break;
            }
        }

        public bool FinalizeChanges(Customer custTemp)
        {
            return customerDB.UpdateDataSource(custTemp);
        }

        #endregion
    }
}
