using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
   
    public class HomeController : Controller
    {
        // GET: Home
       
        [Route("Home/Student")]
        public ActionResult Index()
        {


            return View();
        }

       
        public string Home(int id)
        {
            return "This is My number" + id + "."; 
        }

        [Route("Home/Index")]
        public ActionResult Student()
        {
            return View();
        }
    }
}