using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookingSystem.Business
{
    internal class Receptionist : Person
    {

        #region Data Members
        private int recpNum;
        private int salary;

        #endregion

        #region Property Members

        public int ReceptionistNum
        {
            get { return recpNum; }
            set { recpNum = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        #endregion

        #region Constructor
        public Receptionist(int rNum, int salTemp) : base()
        {
            this.recpNum = rNum;
            this.salary = salTemp;
        }

        #endregion 

    }
}
