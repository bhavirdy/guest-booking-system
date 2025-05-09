﻿using GuestBookingSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookingSystem.Business;

namespace GuestBookingSystem.Data
{
    internal class RoomDB : DB
    {

        #region Data Members
        private String table = "Room";
        private String st = "Select * FROM Room";
        private Collection<Room> rooms;

        #endregion

        #region Property Methods

        public Collection<Room> Rooms { get { return rooms; } }
        #endregion

        #region Constructor

        public RoomDB() : base()
        {
            rooms = new Collection<Room>();
            FillDataSet(st, table);
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
            Room roomTemp = null;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[tableTemp].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    roomTemp = new Room();
                    roomTemp.RoomID = Convert.ToInt32(myRow["RoomID"]);
                    roomTemp.NumBeds = Convert.ToInt32(myRow["NumBeds"]);
                }

                rooms.Add(roomTemp);
            }
        }

        #endregion
    }
}
