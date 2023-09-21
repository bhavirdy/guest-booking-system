using GuestBookingSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookingSystem.Business;

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

        public DataSet GetDataSet()
        {
            return dsMain;
        }

        #region Utility Methods
        private void Add2Collection(String tableTemp)
        {
            DataRow myRow = null;
            Customer custTemp = null;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[tableTemp].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //custTemp = new Customer();
                }

                customers.Add(custTemp);
            }
        }

        private void FillRow(DataRow rowTemp, Customer custTemp)
        {
            rowTemp["CustomerID"] = custTemp.CustID;
            rowTemp["Name"] = custTemp.Name;
            rowTemp["Surname"] = custTemp.Surname;
            rowTemp["Email"] = custTemp.Email;
            rowTemp["StreetAdress"] = custTemp.StreetAddress;
            rowTemp["townOrCity"] = custTemp.TownOrCity;
            rowTemp["Country"] = custTemp.Country;
            rowTemp["PostalCode"] = custTemp.PostalCode;
            rowTemp["Phone"] = custTemp.Phone;
            rowTemp["CardNumber"] = custTemp.CardNumber;
        }
        #endregion

        #region Database CRUD

        public void DataSetChange(Customer custTemp)
        {
            DataRow rowTemp = null;
            String dataTable = table;
            rowTemp = dsMain.Tables[dataTable].NewRow();
            FillRow(rowTemp, custTemp);
            dsMain.Tables[dataTable].Rows.Add(rowTemp);
        }

        private void BUILD_INSERT_Parameters(Customer custTemp)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@CustomerID", SqlDbType.Int, 50, "CustomerID");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Surname", SqlDbType.NVarChar, 50, "Surname");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Email", SqlDbType.NVarChar, 50, "Email");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@StreetAddress", SqlDbType.NVarChar, 50, "StreetAddress");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@TownOrCity", SqlDbType.NVarChar, 50, "Town");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@PostalCode", SqlDbType.NVarChar, 50, "PostalCode");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Province", SqlDbType.NVarChar, 50, "Province");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 10, "Phone");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@CardNumber", SqlDbType.NVarChar, 16, "CardNumber");
            daMain.InsertCommand.Parameters.Add(param);


        }

        private void CREATE_INSERT_Command(Customer custTemp)
        {
            daMain.InsertCommand = new SqlCommand("INSERT into Customer (CustomerID, Name, Surname, Email, StreetAdress, TownOrCity, Province, PostalCode, Phone, CardNumber) VALUES (@CustomerID, @Name, @Surname, @Email, @StreetAddress, @TownOrCity, @Province, @PostalCode, @Phone, @CardNumber", cnMain);
            BUILD_INSERT_Parameters(custTemp);
        }

        public bool UpdateDataSource(Customer custTemp)
        {
            bool success = true;
            CREATE_INSERT_Command(custTemp);
            success = UpdateDataSource(sqlSt, table);
            return success;
        }

        #endregion

    }
}
