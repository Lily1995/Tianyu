using System;
using System.Collections.Generic;
using System.Text;

namespace FilmsSelect.Models
{
    public class Hall
    {
        private int hID;
        public int HID
        {
            get { return hID; }
            set { hID = value; }
        }

        private string hHall;
        public string HHall
        {
            get { return hHall; }
            set { hHall = value; }
        }
    }
}
