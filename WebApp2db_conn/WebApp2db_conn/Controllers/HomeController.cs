using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp2db_conn.db_context;

namespace WebApp2db_conn.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            abhiEntities obj = new abhiEntities();

          //  mvctable obj = new mvctable();
            var res = obj.mvctables.ToList();

            return View(res);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}