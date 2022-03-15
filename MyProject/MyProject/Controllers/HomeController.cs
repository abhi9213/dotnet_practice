using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //ViewBag.abc = "hi abhi";

            //ViewBag.tst1 = 1234;

            //ViewBag.test2 = 123.56f;

            //ViewBag.test3 = 56.4568;

            //ViewBag.list = new List<string>() {
            //    "india",
            //    "usa",
            //        "uk"};


            //return View();


            //employeemodel obj = new employeemodel();
            //obj.name = "abhinav";
            //obj.id = 1234567;
            //obj.email = "abhi123@gmail";

            //return View(obj);


            //ViewData["abc"] = "view data value";
            //ViewData["test1"] = 8888;
            //ViewData["test2"] = 88.555f;
            //ViewData["test3"] = 51.8888;
            //ViewData["test4"] = DateTime.Now;
            ////ViewData["listdata"] = new List<string>() { 
            ////"india","usa","uk"

            ////};
            //return View();


            ////temp data exp
            ///
            //TempData["abc"] = "temp data value";
            //TempData["test1"] = 123.456f;
            //TempData["test2"] = 777.4568742;
            //TempData["test3"] = DateTime.Now;
            //return View();

            Session["test1"] = "this is session example";
            Session["test2"] = 1234.456;



            return View();
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