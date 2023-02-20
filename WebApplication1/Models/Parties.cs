using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApplication1.Models
{
    public class Parties
    {

        #region "Member Variables"
        private int _PARTICIPANT_ID;
        private string _FULL_NAME;
        private string _DISPOSITION_TYPE_NAME;
        private string _NATNO;
        #endregion

        #region "Public Properties"
        [DataMember()]
        public int PARTICIPANT_ID
        {
            get { return _PARTICIPANT_ID; }
            set { _PARTICIPANT_ID = value; }
        }
        [DataMember()]
        public string NATNO
        {
            get { return _NATNO; }
            set { _NATNO = value; }
        }
        [DataMember()]
        public string FULL_NAME
        {
            get { return _FULL_NAME; }
            set { _FULL_NAME = value; }
        }
        [DataMember()]
        public string DISPOSITION_TYPE_NAME
        {
            get { return _DISPOSITION_TYPE_NAME; }
            set { _DISPOSITION_TYPE_NAME = value; }
        }
        #endregion
    }
}