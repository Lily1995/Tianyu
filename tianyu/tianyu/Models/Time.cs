using System;
using System.Collections.Generic;
using System.Text;

namespace FilmsSelect.Models
{

    public class Time
    {
        private int tID;
        public int TID
        {
            get { return tID; }
            set { tID = value; }
        }

        private string tTime;
        public string TTime
        {
            get { return tTime; }
            set { tTime = value; }
        }

        private int tHallID;
        public int THallID
        {
            get { return tHallID; }
            set { tHallID = value; }
        }
    }
}
