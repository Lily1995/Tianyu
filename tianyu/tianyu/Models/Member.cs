using System;
using System.Collections.Generic;
using System.Text;

namespace FilmsSelect.Models
{
    public class Member
    {
        private int mID;
        public int MID
        {
            get { return mID; }
            set { mID = value; }
        }

        private string mName;
        public string MName
        {
            get { return mName; }
            set { mName = value; }
        }

        private string mIDcard;
        public string MIDcard
        {
            get { return mIDcard; }
            set { mIDcard = value; }
        }

        private string mPhone;
        public string MPhone
        {
            get { return mPhone; }
            set { mPhone = value; }
        }

        private string mType;
        public string MType
        {
            get { return mType; }
            set { mType = value; }
        }

        private int mDiscount;
        public int MDiscount
        {
            get { return mDiscount; }
            set { mDiscount = value; }
        }

    }
}
