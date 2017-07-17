using System;
using System.Collections.Generic;
using System.Text;

namespace FilmsSelect.Models
{
    public class Types
    {
        private int tID;
        public int TID
        {
            get { return tID; }
            set { tID = value; }
        }

        private string tLgoinType;
        public string TLgoinType
        {
            get { return tLgoinType; }
            set { tLgoinType = value; }
        }

        private string tLgionId;
        public string TLgionId
        {
            get { return tLgionId; }
            set { tLgionId = value; }
        }

        private string tLgionPwd;
        public string TLgionPwd
        {
            get { return tLgionPwd; }
            set { tLgionPwd = value; }
        }

        private string tName;
        public string TName
        {
            get { return tName; }
            set { tName = value; }
        }

        private string tSex;
        public string TSex
        {
            get { return tSex; }
            set { tSex = value; }
        }
    }
}
