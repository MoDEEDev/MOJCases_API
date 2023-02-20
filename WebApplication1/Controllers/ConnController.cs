using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ConnController : Controller
    {
        // GET: Conn
        public ActionResult Index()
        {
            return View();
        }
        public static string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["ConnectionString"].ToString(); }
        }
        public static string ConnectionStringomicron
        {
            get { return ConfigurationManager.ConnectionStrings["ConnectionStringomicron"].ToString(); }
        }
    }
}