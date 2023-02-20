using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApplication1.Models
{
    public class CaseMainInfo1
    {
        #region "Member Variables" 

        private int _CLOCATION_CODE;
        private int _CTYPE_CODEL;
        private long _CASE_SERIAL;
        private int _CASE_YEAR;
        private int _REG_BOOK_CODE;
        private string _CASE_CAPTION;
        private DateTime _CASE_DATE;
        private long _FEE_AMOUNT;
        private long _CASE_ID;
        private long _LINKED_CASE_ID;       
        private int _CASE_TYPE_CODE;
        private string _CLASS_NAME;
        private DateTime _CREATION_DATE;
        private string _END_TYPE_NAME;
        private DateTime _JUDGMENT_DATE;
        private string _PANEL_NAME;
        private string _SOURCE_PLACE_NAME;
        private int _STATUS_CODE;
        private string _STATUS_NAME;

      

        #endregion

        #region "Public Properties"

        [DataMember()]
        public int CLOCATION_CODE
        {
            get { return _CLOCATION_CODE; }
            set { _CLOCATION_CODE = value; }
        }

        [DataMember()]
        public int CTYPE_CODE
        {
            get { return _CTYPE_CODEL; }
            set { _CTYPE_CODEL = value; }
        }

        [DataMember()]
        public long CASE_SERIAL
        {
            get { return _CASE_SERIAL; }
            set { _CASE_SERIAL = value; }
        }

        [DataMember()]
        public int CASE_YEAR
        {
            get { return _CASE_YEAR; }
            set { _CASE_YEAR = value; }
        }

        [DataMember()]
        public int REG_BOOK_CODE
        {
            get { return _REG_BOOK_CODE; }
            set { _REG_BOOK_CODE = value; }
        }

        [DataMember()]
        public string CASE_CAPTION
        {
            get { return _CASE_CAPTION; }
            set { _CASE_CAPTION = value; }
        }

        [DataMember()]
        public DateTime CASE_DATE
        {
            get { return _CASE_DATE; }
            set { _CASE_DATE = value; }
        }

        [DataMember()]
        public long FEE_AMOUNT
        {
            get { return _FEE_AMOUNT; }
            set { _FEE_AMOUNT = value; }
        }

        [DataMember()]
        public long CASE_ID
        {
            get { return _CASE_ID; }
            set { _CASE_ID = value; }
        }

        [DataMember()]
        public long LINKED_CASE_ID
        {
            get { return _LINKED_CASE_ID; }
            set { _LINKED_CASE_ID = value; }
        }

        [DataMember()]
        public int CASE_TYPE_CODE
        {
            get { return _CASE_TYPE_CODE; }
            set { _CASE_TYPE_CODE = value; }
        }

        [DataMember()]
        public string CLASS_NAME
        {
            get { return _CLASS_NAME; }
            set { _CLASS_NAME = value; }
        }

        [DataMember()]
        public DateTime CREATION_DATE
        {
            get { return _CREATION_DATE; }
            set { _CREATION_DATE = value; }
        }

        [DataMember()]
        public string END_TYPE_NAME
        {
            get { return _END_TYPE_NAME; }
            set { _END_TYPE_NAME = value; }
        }

        [DataMember()]
        public DateTime JUDGMENT_DATE
        {
            get { return _JUDGMENT_DATE; }
            set { _JUDGMENT_DATE = value; }
        }

        [DataMember()]
        public string PANEL_NAME
        {
            get { return _PANEL_NAME; }
            set { _PANEL_NAME = value; }
        }

        [DataMember()]
        public string SOURCE_PLACE_NAME
        {
            get { return _SOURCE_PLACE_NAME; }
            set { _SOURCE_PLACE_NAME = value; }
        }

        [DataMember()]
        public int STATUS_CODE
        {
            get { return _STATUS_CODE; }
            set { _STATUS_CODE = value; }
        }

        [DataMember()]
        public string STATUS_NAME
        {
            get { return _STATUS_NAME; }
            set { _STATUS_NAME = value; }
        }

        #endregion
    }
}