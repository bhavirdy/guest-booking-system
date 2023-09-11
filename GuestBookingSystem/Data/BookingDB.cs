using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookingSystem.Business;

namespace GuestBookingSystem.Data
{
    internal class BookingDB : DB
    {

        private String table = "Booking";
        private String sqlSt = "Select * From Booking";
        private Collection<Booking> bookings;

        public Collection<Booking> AllBookings
        {
            get { return bookings; }
        }

        public BookingDB() : base()
        {
            bookings = new Collection<Booking>();
            FillDataSet(sqlSt, table);
            AddToCollection(table);
        }

        public DataSet GetDataSet()
        {
            return dsMain;
        }

        private void AddToCollection(String tableTemp)
        {
            DataRow myRow = null;
            Booking bookTemp;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[tableTemp].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    bookTemp = new Booking();
                    bookTemp.CustomerID = Convert.ToInt32(myRow["CustomerID"]);
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
            param = new SqlParameter("@ArriveDate", SqlDbType.DateTime, DateTime, "ArriveDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@LeaveDate", SqlDbType.DateTime, DateTime, "LeaveDate");
            daMain.InsertCommand.Paramters.Add(param);
            param = new SqlParameter("@RoomID", SqlDbType.NVarChar, 15, "RoomID");
            daMain.InsertCommand.Parameters.Insert(param);
            param = new SqlParameter("@Deposit", SqlDbType.NVarChar, 15, "Deposit");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@TotalPrice", SqlDbType.NVarChar, 15, "@TotalPrice");



        }

        private void CREATE_INSERT_Command(Booking bTemp)
        {
            daMain.InsertCommand = new SqlCommand("INSERT into Booking (CustomerID, ArriveDate, LeaveDate, RoomID, Deposit, TotalPrice) VALUES (@CustomerID, @ArriveDate, @LeaveDate, @RoomID, @Deposit, @TotalPrice", cnMain);
            BUILD_INSERT_Parameters(bTemp);
        }

        public bool UpdateDataSource(Booking bTemp)
        {

        }
    }

}
