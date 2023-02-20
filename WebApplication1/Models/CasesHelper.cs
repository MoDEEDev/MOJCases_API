
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CasesHelper
    {
        public Cases GetCasesHelper(OracleDataReader reader)
        {
            Cases CasesObj = new Cases();
            if (reader["CASECLASSIFICATION"] != DBNull.Value)
            {
                CasesObj.CASECLASSIFICATION = (string)reader["CASECLASSIFICATION"];
            }
            if (reader["CASE_ID"] != DBNull.Value)
            {
                CasesObj.CASE_ID = Convert.ToInt32(reader["CASE_ID"]);
            }
            if (reader["CASE_SERIAL"] != DBNull.Value)
            {
                CasesObj.CASE_SERIAL = Convert.ToInt32(reader["CASE_SERIAL"]);
            }
            if (reader["CASE_STATUS"] != DBNull.Value)
            {
                CasesObj.CASE_STATUS = (string)reader["CASE_STATUS"];
            }
            if (reader["CASE_YEAR"] != DBNull.Value)
            {
                CasesObj.CASE_YEAR = Convert.ToInt32(reader["CASE_YEAR"]);
            }
            if (reader["CLASS_CODE"] != DBNull.Value)
            {
                CasesObj.CLASS_CODE = Convert.ToInt32(reader["CLASS_CODE"]);
            }
            if (reader["COURT_CODE"] != DBNull.Value)
            {
                CasesObj.COURT_CODE = Convert.ToInt32(reader["COURT_CODE"]);
            }
            if (reader["COURT_NAME"] != DBNull.Value)
            {
                CasesObj.COURT_NAME = (string)reader["COURT_NAME"];
            }
            if (reader["ENDYEAR"] != DBNull.Value)
            {
                CasesObj.ENDYEAR = Convert.ToInt32(reader["ENDYEAR"]);
            }
            if (reader["END_TYPE"] != DBNull.Value)
            {
                CasesObj.END_TYPE = (string)reader["END_TYPE"];
            }
            if (reader["JUDGMENT_DATE"] != DBNull.Value)
            {
                CasesObj.JUDGMENT_DATE = Convert.ToDateTime(reader["JUDGMENT_DATE"]);
            }
            if (reader["PROS_CASE_ID"] != DBNull.Value)
            {
                CasesObj.PROS_CASE_ID = Convert.ToInt32(reader["PROS_CASE_ID"]);
            }
            if (reader["PROS_CASE_SERIAL"] != DBNull.Value)
            {
                CasesObj.PROS_CASE_SERIAL = Convert.ToInt32(reader["PROS_CASE_SERIAL"]);
            }
            if (reader["PROS_CASE_YEAR"] != DBNull.Value)
            {
                CasesObj.PROS_CASE_YEAR = Convert.ToInt32(reader["PROS_CASE_YEAR"]);
            }
            if (reader["PROS_COURT_CODE"] != DBNull.Value)
            {
                CasesObj.PROS_COURT_CODE = Convert.ToInt32(reader["PROS_COURT_CODE"]);
            }
            if (reader["PROS_COURT_NAME"] != DBNull.Value)
            {
                CasesObj.PROS_COURT_NAME = (string)reader["PROS_COURT_NAME"];
            }
            if (reader["SOURCE_PLACE"] != DBNull.Value)
            {
                CasesObj.SOURCE_PLACE = (string)reader["SOURCE_PLACE"];
            }
            return CasesObj;
        }
        public Parties GetCasesParties(OracleDataReader reader)
        {
            Parties PartiesObj = new Parties();
            if (reader["PARTICIPANT_ID"] != DBNull.Value)
            {
                PartiesObj.PARTICIPANT_ID = Convert.ToInt32(reader["PARTICIPANT_ID"]);
            }
            if (reader["NATNO"] != DBNull.Value)
            {
                PartiesObj.NATNO = (string)reader["NATNO"];
            }
           
            if (reader["FULL_NAME"] != DBNull.Value)
            {
                PartiesObj.FULL_NAME = (string)reader["FULL_NAME"];
            }
       
            if (reader["DISPOSITION_TYPE_NAME"] != DBNull.Value)
            {
                PartiesObj.DISPOSITION_TYPE_NAME = (string)reader["DISPOSITION_TYPE_NAME"];
            }
            return PartiesObj;
        }
        public CaseMainInfo1 GetCaseMainInfoHelper1(OracleDataReader reader)
        {
            CaseMainInfo1 casemaininfo = new CaseMainInfo1();

            if (reader["CLOCATION_CODE"] != DBNull.Value)
            {
                casemaininfo.CLOCATION_CODE = Convert.ToInt32(reader["CLOCATION_CODE"]);
            }
            if (reader["CTYPE_CODE"] != DBNull.Value)
            {
                casemaininfo.CTYPE_CODE = Convert.ToInt32(reader["CTYPE_CODE"]);
            }
            if (reader["CASE_SERIAL"] != DBNull.Value)
            {
                casemaininfo.CASE_SERIAL = Convert.ToInt64(reader["CASE_SERIAL"]);
            }
            if (reader["CASE_YEAR"] != DBNull.Value)
            {
                casemaininfo.CASE_YEAR = Convert.ToInt16(reader["CASE_YEAR"]);
            }
            if (reader["REG_BOOK_CODE"] != DBNull.Value)
            {
                casemaininfo.REG_BOOK_CODE = Convert.ToInt32(reader["REG_BOOK_CODE"]);
            }
            if (reader["CASE_CAPTION"] != DBNull.Value)
            {
                casemaininfo.CASE_CAPTION = Convert.ToString(reader["CASE_CAPTION"]);
            }
            if (reader["CASE_DATE"] != DBNull.Value)
            {
                casemaininfo.CASE_DATE = Convert.ToDateTime(reader["CASE_DATE"]);
            }
            if (reader["FEE_AMOUNT"] != DBNull.Value)
            {
                casemaininfo.FEE_AMOUNT = Convert.ToInt64(reader["FEE_AMOUNT"]);
            }
            if (reader["CASE_ID"] != DBNull.Value)
            {
                casemaininfo.CASE_ID = Convert.ToInt64(reader["CASE_ID"]);
            }
            if (reader["LINKED_CASE_ID"] != DBNull.Value)
            {
                casemaininfo.LINKED_CASE_ID = Convert.ToInt64(reader["LINKED_CASE_ID"]);
            }
            if (reader["CASE_TYPE_CODE"] != DBNull.Value)
            {
                casemaininfo.CASE_TYPE_CODE = Convert.ToInt32(reader["CASE_TYPE_CODE"]);
            }
            if (reader["CLASS_NAME"] != DBNull.Value)
            {
                casemaininfo.CLASS_NAME = Convert.ToString(reader["CLASS_NAME"]);
            }
            if (reader["CREATION_DATE"] != DBNull.Value)
            {
                casemaininfo.CREATION_DATE = Convert.ToDateTime(reader["CREATION_DATE"]);
            }
            if (reader["END_TYPE_NAME"] != DBNull.Value)
            {
                casemaininfo.END_TYPE_NAME = Convert.ToString(reader["END_TYPE_NAME"]);
            }
            if (reader["JUDGMENT_DATE"] != DBNull.Value)
            {
                casemaininfo.JUDGMENT_DATE = Convert.ToDateTime(reader["JUDGMENT_DATE"]);
            }
            if (reader["PANEL_NAME"] != DBNull.Value)
            {
                casemaininfo.PANEL_NAME = Convert.ToString(reader["PANEL_NAME"]);
            }
            if (reader["SOURCE_PLACE_NAME"] != DBNull.Value)
            {
                casemaininfo.SOURCE_PLACE_NAME = Convert.ToString(reader["SOURCE_PLACE_NAME"]);
            }
            if (reader["STATUS_CODE"] != DBNull.Value)
            {
                casemaininfo.STATUS_CODE = Convert.ToInt32(reader["STATUS_CODE"]);
            }
            if (reader["STATUS_NAME"] != DBNull.Value)
            {
                casemaininfo.STATUS_NAME = Convert.ToString(reader["STATUS_NAME"]);
            }

            return casemaininfo;
        }

    }
}