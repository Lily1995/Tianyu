using System;
using System.Collections.Generic;
using System.Text;

namespace FilmsSelect.Models
{
    public class MemberType
    {
        private int mID;
        public int MID
        {
            get { return mID; }
            set { mID = value; }
        }

        private string mType;
        public string MType
        {
            get { return mType; }
            set { mType = value; }
        }
    }
}
