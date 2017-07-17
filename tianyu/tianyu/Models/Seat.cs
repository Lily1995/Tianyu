using System;
using System.Collections.Generic;
using System.Text;

namespace FilmsSelect.Models
{
    public class Seat
    {
        private int sEID;
        public int SEID
        {
            get { return sEID; }
            set { sEID = value; }
        }

        private string sType;
        public string SType
        {
            get { return sType; }
            set { sType = value; }
        }

        private int sMoney;
        public int SMoney
        {
            get { return sMoney; }
            set { sMoney = value; }
        }

        private string sNumber;
        public string SNumber
        {
            get { return sNumber; }
            set { sNumber = value; }
        }
    }
}
