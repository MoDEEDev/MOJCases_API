using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Http;
using WebApplication1.Models;
using System.Data;
using System.Data.SqlClient;
using System.Data.OracleClient;

namespace WebApplication1.Controllers
{
    public class CasesController : ApiController
    {
        [HttpPost]
        [Route("CaseByClassification")]
        public List<Cases> CaseByClassification(string Classification, string JudgDate)
        {
            try
            {
                Cases result =new Cases();
                List<Cases> reultlis = new List<Cases>();
                string User = System.Threading.Thread.CurrentPrincipal.Identity.Name;
                OracleDataReader reader;
                using (OracleConnection connection = new OracleConnection(ConnController.ConnectionString))
                {
                    string select = "Select * from GSB_CASES_PARTY_ANTI_CORRUPTION where CLASS_CODE=:CLASS_CODE AND  trunc(JUDGMENT_DATE)= to_date('" + JudgDate + "','dd/mm/yyyy')";
                    OracleCommand command = new OracleCommand(select, connection);
                    OracleParameter Pp_Casefication = new OracleParameter("CLASS_CODE", Classification);
                    command.Parameters.Add(Pp_Casefication);
                    connection.Open();
                    reader = command.ExecuteReader();
                    CasesHelper helper = new CasesHelper();
                    while (reader.Read())
                    {
                        result = helper.GetCasesHelper(reader);
                        result.Partieslist = CasesParties(result.CASE_ID);
                        reultlis.Add(result);
                    }
                }
                return reultlis;
            }


            catch (Exception ex)
            {

                HttpResponseMessage message = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Backend Server Error:Method CasesClassification",
                };

                throw new HttpResponseException(message);

            }

        }

        [HttpPost]
        [Route("CaseByNationalNo")]
        public List<Cases> CaseByNationalNo(string CaseByNationalNo)
        {
            try
            {
                Cases result = new Cases();
                List<Cases> reultlis = new List<Cases>();
                string User = System.Threading.Thread.CurrentPrincipal.Identity.Name;
                OracleDataReader reader;
                using (OracleConnection connection = new OracleConnection(ConnController.ConnectionString))
                {
                    string select = "Select * from GSB_CASES_PARTY_ANTI_CORRUPTION where NATNO=:NATNO";
                    OracleCommand command = new OracleCommand(select, connection);
                    OracleParameter Pp_NATNO = new OracleParameter("NATNO", CaseByNationalNo);
                    command.Parameters.Add(Pp_NATNO);
                    connection.Open();
                    reader = command.ExecuteReader();
                    CasesHelper helper = new CasesHelper();
                    while (reader.Read())
                    {
                        result = helper.GetCasesHelper(reader);
                        result.Partieslist = CasesParties(result.CASE_ID);
                        reultlis.Add(result);
                    }
                }
                return reultlis;
            }


            catch (Exception ex)
            {

                HttpResponseMessage message = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Backend Server Error:Method CaseByNationalNo",
                };

                throw new HttpResponseException(message);

            }

        }

        [HttpPost]
        [Route("CaseByNumber")]
        public List<Cases> CaseByNumber(string PROS_CASE_ID, string PROS_CASE_SERIAL,string PROS_CASE_YEAR)
        {
            try
            {
                Cases result = new Cases();
                List<Cases> reultlis = new List<Cases>();
                string User = System.Threading.Thread.CurrentPrincipal.Identity.Name;
                OracleDataReader reader;
                using (OracleConnection connection = new OracleConnection(ConnController.ConnectionString))
                {
                    string select = "Select * from GSB_cases_anti_corruption where PROS_CASE_ID=:PROS_CASE_ID AND PROS_CASE_SERIAL=:PROS_CASE_SERIAL AND PROS_CASE_YEAR=:PROS_CASE_YEAR ";
                    OracleCommand command = new OracleCommand(select, connection);
                    OracleParameter Pp_PROS_CASE_ID = new OracleParameter("PROS_CASE_ID", PROS_CASE_ID);
                    command.Parameters.Add(Pp_PROS_CASE_ID);
                    OracleParameter PP_PROS_CASE_SERIAL = new OracleParameter("PROS_CASE_SERIAL", PROS_CASE_SERIAL);
                    command.Parameters.Add(PP_PROS_CASE_SERIAL);
                    OracleParameter PP_PROS_CASE_YEAR = new OracleParameter("PROS_CASE_YEAR", PROS_CASE_YEAR);
                    command.Parameters.Add(PP_PROS_CASE_YEAR);
                    connection.Open();
                    reader = command.ExecuteReader();
                    CasesHelper helper = new CasesHelper();
                    while (reader.Read())
                    {
                        result = helper.GetCasesHelper(reader);
                        result.Partieslist = CasesParties(result.CASE_ID);
                        reultlis.Add(result);
                    }
                }
                return reultlis;
            }


            catch (Exception ex)
            {

                HttpResponseMessage message = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Backend Server Error:Method CasesClassification",
                };

                throw new HttpResponseException(message);

            }

        }

        [HttpPost]
        [Route("GetCasesMainInfo")]
        public List<CaseMainInfo1> GetCasesMainInfo(int CASE_YEAR,int CASE_SERIAL)
        {
            try
            {
                CaseMainInfo1 result = new CaseMainInfo1();
                List<CaseMainInfo1> reultlis = new List<CaseMainInfo1>();
                OracleDataReader reader;
                using (OracleConnection connection = new OracleConnection(ConnController.ConnectionStringomicron))
                {
                    string select = "Select * from ESB_CASE_MAIN_INFO1 where CASE_YEAR=:CASE_YEAR AND CASE_SERIAL=:CASE_SERIAL";
                    OracleCommand command = new OracleCommand(select, connection);
                    OracleParameter Pp_CASE_YEAR = new OracleParameter("CASE_YEAR", CASE_YEAR);
                    command.Parameters.Add(Pp_CASE_YEAR);
                    OracleParameter PP_CASE_SERIAL = new OracleParameter("CASE_SERIAL", CASE_SERIAL);
                    command.Parameters.Add(PP_CASE_SERIAL);

                    connection.Open();
                    reader = command.ExecuteReader();
                    CasesHelper helper = new CasesHelper();
                    while (reader.Read())
                    {
                        result = helper.GetCaseMainInfoHelper1(reader);
                        reultlis.Add(result);
                    }
                }
                return reultlis;
            }


            catch (Exception ex)
            {

                HttpResponseMessage message = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Backend Server Error:Method GetCasesMainInfo",
                };

                throw new HttpResponseException(message);

            }
        }
        ////[HttpPost]
        ////[Route("CaseByYear")]
        ////public List<Cases> CaseByYear(string CASE_YEAR)
        ////{
        ////    //try
        ////    //{
        ////        Cases result = new Cases();
        ////        List<Cases> reultlis = new List<Cases>();
        ////        string User = System.Threading.Thread.CurrentPrincipal.Identity.Name;
        ////        OracleDataReader reader;
        ////        using (OracleConnection connection = new OracleConnection(ConnController.ConnectionString))
        ////        {
        ////            string select = "Select * from GSB_cases_anti_corruption where CASE_YEAR=:CASE_YEAR";
        ////            OracleCommand command = new OracleCommand(select, connection);
        ////            OracleParameter Pp_CASE_YEAR = new OracleParameter("CASE_YEAR", CASE_YEAR);
        ////            command.Parameters.Add(Pp_CASE_YEAR);
        ////            connection.Open();
        ////            reader = command.ExecuteReader();
        ////            CasesHelper helper = new CasesHelper();
        ////            while (reader.Read())
        ////            {
        ////                result = helper.GetCasesHelper(reader);
        ////                result.Partieslist = CasesParties(result.CASE_ID);
        ////                reultlis.Add(result);
        ////            }
        ////        }
        ////        return reultlis;
        ////  //  }


        ////    //catch (Exception ex)
        ////    //{

        ////    //    HttpResponseMessage message = new HttpResponseMessage(HttpStatusCode.InternalServerError)
        ////    //    {
        ////    //        ReasonPhrase = "Backend Server Error:Method CasesClassification",
        ////    //    };

        ////    //    throw new HttpResponseException(message);

        ////    //}

        ////}

        private List<Parties> CasesParties(int CASE_ID)
        {
            try
            {
                Parties result = new Parties();
                List<Parties> reultlis = new List<Parties>();
                string User = System.Threading.Thread.CurrentPrincipal.Identity.Name;
                OracleDataReader reader;
                string select = "Select * from GSB_cases_party_anti_corruption where CASE_ID=:CASE_ID";
                using (OracleConnection connection = new OracleConnection(ConnController.ConnectionString))
                {
                    OracleCommand command = new OracleCommand(select, connection);
                    OracleParameter Case_ID = new OracleParameter("CASE_ID", CASE_ID);
                    command.Parameters.Add(Case_ID);
                    connection.Open();
                    reader = command.ExecuteReader();
                    CasesHelper helper = new CasesHelper();
                    while (reader.Read())
                    {
                        result = helper.GetCasesParties(reader);
                        reultlis.Add(result);
                    }
                }
                return reultlis;
            }


            catch (Exception ex)
            {

                HttpResponseMessage message = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Backend Server Error:Parties",
                };

                throw new HttpResponseException(message);

            }
        }
    }
}