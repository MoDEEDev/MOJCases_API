using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApplication1.Models
{
    public class Cases
    {
        #region "Member Variables"

        private int _CASE_ID;
        private int _CASE_SERIAL;
        private int _CASE_YEAR;
        private string _COURT_NAME;
        private int _COURT_CODE;
        private string _CASE_STATUS;
        private int _CLASS_CODE;
        private string _CASECLASSIFICATION;
        private string _SOURCE_PLACE;
        private int _ENDYEAR;
        private DateTime _JUDGMENT_DATE;
        private string _END_TYPE;
        private int _PROS_CASE_ID;
        private int _PROS_CASE_SERIAL;
        private int _PROS_CASE_YEAR;
        private int _PROS_COURT_CODE;
        private string _PROS_COURT_NAME;
        private List<Parties> _partieslist;    

        #endregion

        #region "Public Properties"
        [DataMember()]
        public int CASE_ID
        {
            get { return _CASE_ID; }
            set { _CASE_ID = value; }
        }
        [DataMember()]
        public int CASE_SERIAL
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
        public string COURT_NAME
        {
            get { return _COURT_NAME; }
            set { _COURT_NAME = value; }
        }
        [DataMember()]
        public int COURT_CODE
        {
            get { return _COURT_CODE; }
            set { _COURT_CODE = value; }
        }
        [DataMember()]
        public int CLASS_CODE
        {
            get { return _CLASS_CODE; }
            set { _CLASS_CODE = value; }
        }
        [DataMember()]
        public string CASE_STATUS
        {
            get { return _CASE_STATUS; }
            set { _CASE_STATUS = value; }
        }
        [DataMember()]
        public string CASECLASSIFICATION
        {
            get { return _CASECLASSIFICATION; }
            set { _CASECLASSIFICATION = value; }
        }
     
        [DataMember()]
        public string SOURCE_PLACE
        {
            get { return _SOURCE_PLACE; }
            set { _SOURCE_PLACE = value; }
        }
        [DataMember()]
        public int ENDYEAR
        {
            get { return _ENDYEAR; }
            set { _ENDYEAR = value; }
        }
        [DataMember()]
        public DateTime JUDGMENT_DATE
        {
            get { return _JUDGMENT_DATE; }
            set { _JUDGMENT_DATE = value; }
        }
        [DataMember()]
        public string END_TYPE
        {
            get { return _END_TYPE; }
            set { _END_TYPE = value; }
        }
        [DataMember()]
        public int PROS_CASE_ID
        {
            get { return _PROS_CASE_ID; }
            set { _PROS_CASE_ID = value; }
        }
        [DataMember()]
        public int PROS_CASE_SERIAL
        {
            get { return _PROS_CASE_SERIAL; }
            set { _PROS_CASE_SERIAL = value; }
        }
        [DataMember()]
        public int PROS_CASE_YEAR
        {
            get { return _PROS_CASE_YEAR; }
            set { _PROS_CASE_YEAR = value; }
        }
        [DataMember()]
        public int PROS_COURT_CODE
        {
            get { return _PROS_COURT_CODE; }
            set { _PROS_COURT_CODE = value; }
        }
        [DataMember()]
        public string PROS_COURT_NAME
        {
            get { return _PROS_COURT_NAME; }
            set { _PROS_COURT_NAME = value; }
        }
        [DataMember()]
        public List<Parties> Partieslist
        {
            get { return _partieslist; }
            set { _partieslist = value; }
        }
        #endregion
    }
}