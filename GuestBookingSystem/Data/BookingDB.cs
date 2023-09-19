using GuestBookingSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookingSystem.Data
{
    internal class BookingDB
    {

        #region Data Members

        private String table = "Booking";
        private String sqlSt = "Select * From Booking";
        private Collection<Booking> bookings;

        #endregion

        #region Property Methods
        public Collection<Booking> AllBookings
        {
            get { return bookings; }
        }

        #endregion

        #region Constructor

        public BookingDB() : base()
        {
            bookings = new Collection<Booking>();
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
            Booking bookTemp = null;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[tableTemp].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    bookTemp = new Booking();
                    bookTemp.CustomerID = Convert.ToString(myRow["CustomerID"]);
                    bookTemp.Deposit = Convert.ToDouble(myRow["Deposit"]);
                    bookTemp.RoomNumber = Convert.ToInt32(myRow["RoomID"]);
                    bookTemp.ArriveDate = Convert.ToDateTime(myRow["ArriveDate"]);
                    bookTemp.LeaveDate = Convert.ToDateTime(myRow["LeaveDate"]);
                    bookTemp.TotalPrice = Convert.ToInt32(myRow["TotalPrice"]);


                }

                bookings.Add(bookTemp);
            }
        }

        private void FillRow(DataRow rowTemp, Booking bookTemp)
        {
            rowTemp["CustomerID"] = bookTemp.CustomerID;
            rowTemp["ArriveDate"] = bookTemp.ArriveDate;
            rowTemp["LeaveDate"] = bookTemp.LeaveDate;
            rowTemp["Deposit"] = bookTemp.Deposit;
            rowTemp["TotalPrice"] = bookTemp.Deposit;
            rowTemp["RoomID"] = bookTemp.RoomNumber;
        }
        #endregion

        #region Database CRUD

        public void DataSetChange(Booking bookTemp)
        {
            DataRow rowTemp = null;
            String dataTable = table;
            rowTemp = dsMain.Tables[dataTable].NewRow();
            FillRow(rowTemp, bookTemp);
            dsMain.Tables[dataTable].Rows.Add(rowTemp);
        }

        private void BUILD_INSERT_Parameters(Booking bTemp)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@CustomerID", SqlDbType.NVarChar, 15, "CustomerID");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@ArriveDate", SqlDbType.DateTime, 100, "ArriveDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@LeaveDate", SqlDbType.DateTime, 100, "LeaveDate");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@RoomID", SqlDbType.NVarChar, 15, "RoomID");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Deposit", SqlDbType.NVarChar, 15, "Deposit");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@TotalPrice", SqlDbType.NVarChar, 15, "@TotalPrice");
            daMain.InsertCommand.Parameters.Add(param);


        }

        private void CREATE_INSERT_Command(Booking bTemp)
        {
            daMain.InsertCommand = new SqlCommand("INSERT into Booking (CustomerID, ArriveDate, LeaveDate, RoomID, Deposit, TotalPrice) VALUES (@CustomerID, @ArriveDate, @LeaveDate, @RoomID, @Deposit, @TotalPrice", cnMain);
            BUILD_INSERT_Parameters(bTemp);
        }

        public bool UpdateDataSource(Booking bTemp)
        {
            bool success = true;
            CREATE_INSERT_Command(bTemp);
            success = UpdateDataSource(sqlSt, table);
            return success;
        }

        #endregion
    }
}
