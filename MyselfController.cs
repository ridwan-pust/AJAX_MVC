using AjaxCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxCRUD.Controllers
{
    public class MyselfController : Controller
    {
        private readonly Entities db = new Entities();

        // GET: Myself
        public ActionResult Create()
        {

            return View();
        }
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult List()
        {
            var obj=db.Students.ToList();
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}