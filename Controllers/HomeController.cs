using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebFormDemo.Controllers
{
    public class HomeController : Controller
    {
        public String Index1(string id,string name)
        {
            return "Welcome to Asp.NET application"+ "Id="+id +"Name=" + name;
        }

        public ActionResult Index()
        {
            ViewData["Countries"] = new List<String> {"London","USA","Chennai" };
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