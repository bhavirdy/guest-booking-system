using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookingSystem.Business
{
    internal class Room
    {

        #region DataMembers
        private int roomID;
        private bool serviced;
        private int numBeds;

        #endregion

        #region Property Members
        public int RoomID
        {
            get { return roomID; } 
            set {  roomID = value; }
        }

        public bool Serviced
        {
            get { return serviced; }
            set { serviced = value; }
        }

        public int NumBeds
        {
            get { return numBeds; }
            set { numBeds = value; }
        }

        #endregion

        #region Constructor

        public Room(int roomIDTemp,  bool servicedTemp, int numBedsTemp)
        {
            roomID = roomIDTemp;
            serviced = servicedTemp;
            numBeds = numBedsTemp;
        }

        #endregion 
    }
}
