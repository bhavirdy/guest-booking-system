using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookingSystem.Business
{
    internal class Room
    {
        #region Data Members
        private int roomID;
        private int numBeds;
        #endregion

        #region Property Members
        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public int NumBeds
        {
            get { return numBeds; }
            set { numBeds = value; }
        }

        #endregion

        #region Constructors
        
        public Room()
        { }

        public Room(int roomIDTemp, int numBedsTemp) { 
            roomID = roomIDTemp;
            numBeds = numBedsTemp;
        }

        #endregion 
    }
}
