using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookingSystem.Properties;
using System.Windows.Forms;

namespace GuestBookingSystem.Data
{
    internal class DB
    {
        #region Data Members
        private string strConn = Settings.Default.HotelBookingDatabaseConnectionString;
        protected SqlConnection cnMain;
        protected DataSet dsMain;
        protected SqlDataAdapter daMain;

        public enum DBOperation
        {
            Add = 0,
            Edit = 1,
            Delete = 2,
        }

        #endregion 

        #region Constructor
        public DB()
        {
            try
            {

                cnMain = new SqlConnection(strConn);
                dsMain = new DataSet();
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return;
            }
        }

        #endregion

        #region Update the data source

        public void FillDataSet(string SQLstringTemp, string tableTemp)
        {

            try
            {
                daMain = new SqlDataAdapter(SQLstringTemp, cnMain);
                cnMain.Open();
                daMain.Fill(dsMain, tableTemp);
                cnMain.Close();
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
            }
        }

        #endregion 

        #region Update the data source 
        protected bool UpdateDataSource(string sqlLocalTemp, string tableTemp)
        {
            bool success;
            try
            {
                cnMain.Open();
                daMain.Update(dsMain, tableTemp);
                cnMain.Close();
                FillDataSet(sqlLocalTemp, tableTemp);
                success = true;
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                success = false;
            }
            finally
            {
            }
            return success;
        }
        #endregion

    }
}
