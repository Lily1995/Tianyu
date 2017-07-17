using System;
using System.Collections.Generic;
using System.Text;

namespace FilmsSelect.Models
{

    public class Sort
    {
        private int sOID;
        public int SOID
        {
            get { return sOID; }
            set { sOID = value; }
        }

        private string sSort;
        public string SSort
        {
            get { return sSort; }
            set { sSort = value; }
        }
    }
}
