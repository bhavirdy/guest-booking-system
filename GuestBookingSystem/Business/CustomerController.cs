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

        //finds a customer based on the customer ID
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

        //finds the index of the customer in the customers array
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

        //counts the number of customers in a specific province
        public int countCustomers(string prov)
        {
            int count = 0;
            for (int index = 0; index < customerCollection.Count; index++)
            {
                if (customerCollection[index].Province == prov)
                {
                    count++;
                }
            }
            return count;

        }

        #endregion

        #region DataBase Communication

        //Method to edit the collection of customers and make changes to the dataSet 
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

        //method to make changes to the database
        public bool FinalizeChanges(Customer custTemp)
        {
            return customerDB.UpdateDataSource(custTemp);
        }

        //method to generate a unique customer ID
        public String getUniqueCustomerID() { return customerDB.GenerateUniqueCustomerID(); }

        #endregion
    }
}
