using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample.Models;

namespace Sample.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Details(int id)
        {
            StudentEntities student = new StudentEntities();

           Student_Details student_ =  student.Student_Details.Where(i => i.ID == id).Single();

            ViewData["student"] = student_.FirstName;

            return View(student_);
        }
    }
}