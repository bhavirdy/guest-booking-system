﻿using GuestBookingSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookingSystem.Business;
using System.Xml.Linq;

namespace GuestBookingSystem.Data
{
    internal class CustomerDB : DB
    {
        #region Data Members

        private String table = "Customer";
        private String sqlSt = "Select * From Customer";
        private Collection<Customer> customers;

        #endregion

        #region Property Methods
        public Collection<Customer> AllCustomers
        {
            get { return customers; }
        }

        #endregion

        #region Constructor

        public CustomerDB() : base()
        {
            customers = new Collection<Customer>();
            FillDataSet(sqlSt, table);
            Add2Collection(table);
        }

        #endregion

        #region Utility Methods

        public DataSet GetDataSet()
        {
            return dsMain;
        }

        private void Add2Collection(String tableTemp)
        {
            DataRow myRow = null;
            Customer custTemp = null;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[tableTemp].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    custTemp = new Customer();
                    custTemp.CustID = Convert.ToString(myRow["CustomerID"]).TrimEnd();
                    custTemp.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                    custTemp.Surname = Convert.ToString(myRow["Surname"]).TrimEnd();
                    custTemp.Email = Convert.ToString(myRow["Email"]).TrimEnd();
                    custTemp.StreetAddress = Convert.ToString(myRow["StreetAddress"]).TrimEnd();
                    custTemp.TownOrCity = Convert.ToString(myRow["TownOrCity"]).TrimEnd();
                    custTemp.Province = Convert.ToString(myRow["Province"]).TrimEnd();
                    custTemp.Surname = Convert.ToString(myRow["Surname"]).TrimEnd();
                    custTemp.PostalCode = Convert.ToString(myRow["PostalCode"]).TrimEnd();
                    custTemp.Phone = Convert.ToString(myRow["Phone"]).TrimEnd();
                }

                customers.Add(custTemp);
            }
        }

        private void FillRow(DataRow rowTemp, Customer custTemp, DB.DBOperation operation)
        {

            if (operation == DB.DBOperation.Add)
            {
                rowTemp["CustomerID"] = custTemp.CustID;
            }

            rowTemp["Name"] = custTemp.Name;
            rowTemp["Surname"] = custTemp.Surname;
            rowTemp["Email"] = custTemp.Email;
            rowTemp["StreetAddress"] = custTemp.StreetAddress;
            rowTemp["TownOrCity"] = custTemp.TownOrCity;
            rowTemp["Province"] = custTemp.Province;
            rowTemp["PostalCode"] = custTemp.PostalCode;
            rowTemp["Phone"] = custTemp.Phone;
        }

        private int FindRow(Customer custTemp, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;

                // ignore deleted rows
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (custTemp.CustID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["CustomerID"]))
                    {
                        returnValue = rowIndex;
                        break;
                    }
                }

                rowIndex++;
            }
            return returnValue;
        }

        #endregion

        #region Database CRUD

        public void DataSetChange(Customer custTemp, DB.DBOperation operation)
        {
            DataRow rowTemp = null;
            String dataTable = table;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    rowTemp = dsMain.Tables[dataTable].NewRow();
                    FillRow(rowTemp, custTemp, operation);
                    dsMain.Tables[dataTable].Rows.Add(rowTemp);
                    break;

                // For the Edit section you have to find a row instead of creating a new row.
                case DB.DBOperation.Edit:
                    rowTemp = dsMain.Tables[dataTable].Rows[FindRow(custTemp, dataTable)];
                    FillRow(rowTemp, custTemp, operation);
                    break;

                case DB.DBOperation.Delete:
                    rowTemp = dsMain.Tables[dataTable].Rows[FindRow(custTemp, dataTable)];
                    dsMain.Tables[dataTable].Rows.Remove(rowTemp);
                    break;
            }
        }

        private void BUILD_INSERT_Parameters(Customer custTemp)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@CustomerID", SqlDbType.VarChar, 50, "CustomerID");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Name", SqlDbType.VarChar, 50, "Name");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Surname", SqlDbType.VarChar, 50, "Surname");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Email", SqlDbType.VarChar, 50, "Email");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@StreetAddress", SqlDbType.VarChar, 50, "StreetAddress");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@TownOrCity", SqlDbType.VarChar, 50, "TownOrCity");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@PostalCode", SqlDbType.VarChar, 50, "PostalCode");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Province", SqlDbType.VarChar, 50, "Province");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Phone", SqlDbType.VarChar, 50, "Phone");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void CREATE_INSERT_Command(Customer custTemp)
        {
            daMain.InsertCommand = new SqlCommand("INSERT into Customer (CustomerID, Name, Surname, Email, StreetAddress, TownOrCity, Province, PostalCode, Phone) VALUES (@CustomerID, @Name, @Surname, @Email, @StreetAddress, @TownOrCity, @Province, @PostalCode, @Phone)", cnMain);
            BUILD_INSERT_Parameters(custTemp);
        }

        private void BUILD_UPDATE_Parameters(Customer custTemp)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@Original_ID", SqlDbType.VarChar, 50, "CustomerID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.VarChar, 50, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Surname", SqlDbType.VarChar, 50, "Surname");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.VarChar, 50, "Email");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@StreetAddress", SqlDbType.VarChar, 50, "StreetAddress");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@TownOrCity", SqlDbType.VarChar, 50, "TownOrCity");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@PostalCode", SqlDbType.VarChar, 50, "PostalCode");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Province", SqlDbType.VarChar, 50, "Province");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.VarChar, 50, "Phone");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void CREATE_UPDATE_Command(Customer custTemp)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Customer SET Name = @Name, Surname = @Surname, Email = @Email, StreetAddress = @StreetAddress, TownOrCity = @TownOrCity, PostalCode = @PostalCode, Province = @Province, Phone = @Phone " + "WHERE CustomerID = @Original_ID", cnMain);
            BUILD_UPDATE_Parameters(custTemp);
        }

        private void BUILD_DELETE_Parameters(Customer custTemp)
        {
            SqlParameter param = new SqlParameter("@CustomerID", SqlDbType.VarChar, 13, "CustomerID");
            param.SourceVersion = DataRowVersion.Original; // Use Original version for DELETE
            daMain.DeleteCommand.Parameters.Add(param);
        }

        private void CREATE_DELETE_Command(Customer custTemp)
        {
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Customer WHERE CustomerID = @CustomerID", cnMain);
            BUILD_DELETE_Parameters(custTemp);
        }

        public bool UpdateDataSource(Customer custTemp)
        {
            bool success = true;
            CREATE_INSERT_Command(custTemp);
            CREATE_UPDATE_Command(custTemp);
            CREATE_DELETE_Command(custTemp);
            success = UpdateDataSource(sqlSt, table);
            return success;
        }

        public string FindCustomerID(string firstName, string lastName)
        {
            cnMain.Open();

            //sql command to find a customer's ID by first name and last name
            using (var command = new SqlCommand("SELECT CustomerID FROM Customer WHERE Name = @Name AND Surname = @Surname", cnMain))
            {
                command.Parameters.AddWithValue("@Name", firstName);
                command.Parameters.AddWithValue("@Surname", lastName);

                //execute query to retrieve the customer's ID
                var result = command.ExecuteScalar();

                if (result != null)
                {
                    string customerID = result.ToString();
                    cnMain.Close();
                    return customerID;
                }
            }

            cnMain.Close();

            return "-1";
        }
        public string GenerateUniqueCustomerID()
        {
            //characters to be used in booking id
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder customerID = new StringBuilder();

            //uses Random class to build a random booking id of length 13
            Random random = new Random();

            //set a maximum number of attempts to generate a unique ID
            int maxAttempts = 100;
            int attemptCount = 0;

            while (attemptCount < maxAttempts)
            {
                customerID.Clear();

                for (int i = 0; i < 13; i++)
                {
                    int index = random.Next(chars.Length);
                    customerID.Append(chars[index]);
                }

                //check if the generated cust ID already exists in the database
                if (!IsCustomerIDExists(customerID.ToString()))
                {
                    return customerID.ToString(); //return the unique cust ID
                }

                attemptCount++;
            }

            throw new InvalidOperationException("Unable to generate a unique customer ID.");
        }

        private bool IsCustomerIDExists(string customerID)
        {
            cnMain.Open();

            //sql command to check if the booking ID already exists in the Booking table
            using (var command = new SqlCommand("SELECT COUNT(*) FROM Customer WHERE CustomerID = @CustomerID", cnMain))
            {
                command.Parameters.AddWithValue("@CustomerID", customerID);

                //execute the query and get the count
                int count = (int)command.ExecuteScalar();

                cnMain.Close();

                //return true if the count is greater than zero (booking ID exists), otherwise return false
                return count > 0;
            }
        }
    }

    #endregion
}

