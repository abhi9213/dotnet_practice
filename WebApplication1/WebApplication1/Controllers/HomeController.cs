using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public object Session { get; private set; }

        public IActionResult Index()
        {
            //    ViewBag.abc = "hi nabhi";

            //    ViewBag.tst1 = 1234;

            //    ViewBag.test2 = 123.56f;

            //    ViewBag.test3=56.4568;

            //    ViewBag.list = new List<string>() {
            //    "india",
            //    "usa",
            //        "uk"};


            //    return View( );


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

            Session["abc"] = "this is session example";
            Session["test1"] = 1234.456;



            return View();


        }


     
        
    }
}
