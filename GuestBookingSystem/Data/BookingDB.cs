using GuestBookingSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using System.Data.SqlClient;
using System.Data;

using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookingSystem.Business;
using System.Globalization;

namespace GuestBookingSystem.Data
{
    internal class BookingDB : DB
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

        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }

        //adds the bookings in the Bookings table to a collection
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
                    bookTemp.BookingID = Convert.ToString(myRow["BookingID"]).TrimEnd();
                    bookTemp.CustomerID = Convert.ToString(myRow["CustomerID"]).TrimEnd();
                    bookTemp.RoomNumber = Convert.ToInt32(myRow["RoomID"]);
                    bookTemp.ArriveDate = Convert.ToDateTime(myRow["ArriveDate"]);
                    bookTemp.LeaveDate = Convert.ToDateTime(myRow["LeaveDate"]);
                    bookTemp.setDeposit();
                    bookTemp.setPricePerNight();
                    bookTemp.setTotalPrice();
                    bookTemp.CardNumber = Convert.ToString(myRow["CardNumber"]).TrimEnd();
                    bookTemp.Paid = Convert.ToBoolean(myRow["Paid"]);
                }
                bookings.Add(bookTemp);
            }
        }
      
        private void FillRow(DataRow rowTemp, Booking bookTemp, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                rowTemp["BookingID"] = bookTemp.BookingID;
            }

            rowTemp["CustomerID"] = bookTemp.CustomerID;
            rowTemp["ArriveDate"] = bookTemp.ArriveDate;
            rowTemp["LeaveDate"] = bookTemp.LeaveDate;
            rowTemp["RoomID"] = bookTemp.RoomNumber;
            rowTemp["Deposit"] = bookTemp.Deposit;
            rowTemp["TotalPrice"] = bookTemp.TotalPrice;
            rowTemp["PricePerNight"] = bookTemp.PricePerNight;
            rowTemp["CardNumber"] = bookTemp.CardNumber;
            rowTemp["Paid"] = bookTemp.Paid;
        }

        private int FindRow(Booking bookingTemp, string table)
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
                    if (bookingTemp.BookingID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["BookingID"]))
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

        public void DataSetChange(Booking bookingTemp, DB.DBOperation operation)
        {
            DataRow rowTemp = null;
            String dataTable = table;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    rowTemp = dsMain.Tables[dataTable].NewRow();
                    FillRow(rowTemp, bookingTemp, operation);
                    dsMain.Tables[dataTable].Rows.Add(rowTemp);
                    break;

                // For the Edit section you have to find a row instead of creating a new row.
                case DB.DBOperation.Edit:
                    rowTemp = dsMain.Tables[dataTable].Rows[FindRow(bookingTemp, dataTable)];
                    FillRow(rowTemp, bookingTemp, operation);
                    break;

                case DB.DBOperation.Delete:
                    rowTemp = dsMain.Tables[dataTable].Rows[FindRow(bookingTemp, dataTable)];
                    dsMain.Tables[dataTable].Rows.Remove(rowTemp);
                    break;
            }
        }

        private void BUILD_INSERT_Parameters(Booking bTemp)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@BookingID", SqlDbType.VarChar, 13, "BookingID");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@CustomerID", SqlDbType.VarChar, 13, "CustomerID");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@ArriveDate", SqlDbType.DateTime, 8, "ArriveDate");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@LeaveDate", SqlDbType.DateTime, 8, "LeaveDate");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@RoomID", SqlDbType.Int, 4, "RoomID");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Deposit", SqlDbType.Money, 8, "Deposit");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@PricePerNight", SqlDbType.Money, 8, "PricePerNight");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@TotalPrice", SqlDbType.Money, 8, "TotalPrice");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@CardNumber", SqlDbType.VarChar, 16, "CardNumber");
            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@Paid", SqlDbType.Bit, 1, "Paid");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void CREATE_INSERT_Command(Booking bTemp)
        {
            daMain.InsertCommand = new SqlCommand("INSERT into Booking (BookingID, CustomerID, ArriveDate, LeaveDate, RoomID, Deposit, PricePerNight, TotalPrice, CardNumber, Paid) VALUES (@BookingID, @CustomerID, @ArriveDate, @LeaveDate, @RoomID, @Deposit, @PricePerNight, @TotalPrice, @CardNumber, @Paid)", cnMain);
            BUILD_INSERT_Parameters(bTemp);
        }
        private void BUILD_UPDATE_Parameters(Booking bookingTemp)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@Original_ID", SqlDbType.VarChar, 13, "BookingID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CustomerID", SqlDbType.VarChar, 13, "CustomerID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@ArriveDate", SqlDbType.DateTime, 50, "ArriveDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@LeaveDate", SqlDbType.DateTime, 50, "LeaveDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomID", SqlDbType.Int, 4, "RoomID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Deposit", SqlDbType.Money, 8, "Deposit");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@PricePerNight", SqlDbType.Money, 8, "PricePerNight");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@TotalPrice", SqlDbType.Money, 8, "TotalPrice");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CardNumber", SqlDbType.VarChar, 16, "CardNumber");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Paid", SqlDbType.Bit, 1, "Paid");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void CREATE_UPDATE_Command(Booking bookingTemp)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Booking SET CustomerID = @CustomerID, ArriveDate = @ArriveDate, LeaveDate = @LeaveDate, RoomID = @RoomID, Deposit = @Deposit, PricePerNight = @PricePerNight, TotalPrice = @TotalPrice, CardNumber = @CardNumber, Paid = @Paid " + "WHERE BookingID = @Original_ID", cnMain);
            BUILD_UPDATE_Parameters(bookingTemp);
        }

        private void BUILD_DELETE_Parameters(Booking bookingTemp)
        {
            SqlParameter param = new SqlParameter("@BookingID", SqlDbType.VarChar, 50, "BookingID");
            param.SourceVersion = DataRowVersion.Original; // Use Original version for DELETE
            daMain.DeleteCommand.Parameters.Add(param);
        }

        private void CREATE_DELETE_Command(Booking bookingTemp)
        {
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Booking WHERE BookingID = @BookingID", cnMain);
            BUILD_DELETE_Parameters(bookingTemp);
        }

        public bool IsRoomAvailable(int roomID, DateTime arriveDate, DateTime leaveDate)
        {
            cnMain.Open();
            //sql command to check if a given room is available in a given date range
            using (var command = new SqlCommand("SELECT COUNT(*) FROM Booking WHERE RoomID = @RoomID " +
                                                "AND ((ArriveDate <= @LeaveDate AND LeaveDate >= @ArriveDate) " +
                                                "OR (ArriveDate <= @ArriveDate AND LeaveDate >= @LeaveDate))",
                                                cnMain))
            {
                command.Parameters.AddWithValue("@RoomID", roomID);
                command.Parameters.AddWithValue("@ArriveDate", arriveDate);
                command.Parameters.AddWithValue("@LeaveDate", leaveDate);

                // Execute the query to count overlapping bookings
                int overlappingBookingsCount = (int)command.ExecuteScalar();
                cnMain.Close();

                // If there are overlapping bookings, the room is not available and 0 is returned
                return overlappingBookingsCount == 0;
            }
        }

        public string GenerateUniqueBookingID()
        {
            //characters to be used in booking id
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder bookingID = new StringBuilder();

            //uses Random class to build a random booking id of length 13
            Random random = new Random();
            for (int i = 0; i < 13; i++)
            {
                int index = random.Next(chars.Length);
                bookingID.Append(chars[index]);
            }

            return bookingID.ToString();
        }

        public int FindFirstAvailableRoom(DateTime arriveDate, DateTime leaveDate)
        {
            cnMain.Open();
            //sql command to find and return first available room with a given arrive date and leave date
            using (var command = new SqlCommand("SELECT TOP 1 RoomID FROM Room WHERE RoomID NOT IN " +
                                                "(SELECT DISTINCT RoomID FROM Booking " +
                                                "WHERE (ArriveDate <= @LeaveDate AND LeaveDate >= @ArriveDate) " +
                                                "OR (ArriveDate <= @ArriveDate AND LeaveDate >= @LeaveDate))",
                                                cnMain))
            {
                command.Parameters.AddWithValue("@ArriveDate", arriveDate);
                command.Parameters.AddWithValue("@LeaveDate", leaveDate);

                // Execute the query to find the first available room.
                int availableRoomID = (int)command.ExecuteScalar();
                cnMain.Close();

                return availableRoomID;
            }
        }

        //method to get total bookings per month
        public Dictionary<string, int> GetBookingsPerMonth(int year)
        {
            Dictionary<string, int> bookingsPerMonth = new Dictionary<string, int>();

            cnMain.Open();

            //sql command to count bookings per month for all rooms in a specific year
            using (var command = new SqlCommand("SELECT MONTH(ArriveDate) AS Month, COUNT(*) AS BookingCount " +
                                                "FROM Booking " +
                                                "WHERE YEAR(ArriveDate) = @Year " +
                                                "GROUP BY MONTH(ArriveDate)", cnMain))
            {
                command.Parameters.AddWithValue("@Year", year);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int month = reader.GetInt32(0);
                        int count = reader.GetInt32(1);

                        //get the month name from the month number
                        string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

                        //add the month and booking count to the dictionary
                        bookingsPerMonth[monthName] = count;
                    }
                }
            }

            cnMain.Close();

            return bookingsPerMonth;
        }

        public bool UpdateDataSource(Booking bTemp)
        {
            bool success = true;
            CREATE_INSERT_Command(bTemp);
            CREATE_UPDATE_Command(bTemp);
            CREATE_DELETE_Command(bTemp);
            success = UpdateDataSource(sqlSt, table);
            return success;
        }

        #endregion
    }

}
