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
        private int pricePerNight;
        private bool available;

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

        public int PricePerNight
        {
            get { return pricePerNight; }
            set { pricePerNight = value; }
        }

        public bool Available
        {
            get { return available; }
            set { value = available}
        }

        #endregion

        #region Constructor

        public Room(int roomIDTemp,  bool servicedTemp, int numBedsTemp, int priceTemp, bool availTemp)
        {
            roomID = roomIDTemp;
            serviced = servicedTemp;
            numBeds = numBedsTemp;
            pricePerNight = priceTemp;
            available = availTemp;
        }

        #endregion 
    }
}
