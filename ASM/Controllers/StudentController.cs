using ASM.Data;
using ASM.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASM.Models;

namespace ASM.Controllers
{
    public class StudentController : Controller
    {
        private MyDBStudent db = new MyDBStudent();
        // GET: Student
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }
        public ActionResult Create()
        {
            return View();
        } 
        public ActionResult Store(Models.Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return View("Index");
        } 
    }
}