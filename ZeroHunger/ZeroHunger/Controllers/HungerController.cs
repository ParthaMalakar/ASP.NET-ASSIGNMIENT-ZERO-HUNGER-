using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.DB;

namespace ZeroHunger.Controllers
{
    public class HungerController : Controller
    {
        // GET: Hunger
        public ActionResult Index()
        {
            var db = new ZeroHungerEntities();
            var product = db.Restrurants.ToList();
            return View(product);

        }
        [HttpGet]
        public ActionResult Dashboard(int id)
        {
            var db = new ZeroHungerEntities();
            var book = (from b in db.Dashboards
                        where b.RID == id
                        select b).ToList();
            return View(book);
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Restrurant book)
        {

            //add book to db
            var db = new ZeroHungerEntities();
            db.Restrurants.Add(book);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EmployeeNew()
        {
            var db = new ZeroHungerEntities();
            var product = db.Emoplyees.ToList();
            return View(product);

        }
        [HttpGet]
        public ActionResult Creat()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Creat(Emoplyee book)
        {

            //add book to db
            var db = new ZeroHungerEntities();
            db.Emoplyees.Add(book);
            db.SaveChanges();
            return RedirectToAction("EmployeeNew");
        }
        [HttpGet]
        public ActionResult ASSign(int id)
        {
            var db = new ZeroHungerEntities();
            var book = (from b in db.Emoplyees
                        where b.Id == id
                        select b).SingleOrDefault();
            return View(book);
        }
        [HttpPost]
        public ActionResult ASSign(Emoplyee book)
        {
            var db = new ZeroHungerEntities();
       
            var ext = (from b in db.Emoplyees
                       where b.Id == book.Id
                       select b).SingleOrDefault();
        

            db.Entry(ext).CurrentValues.SetValues(book);

            db.SaveChanges();

            return RedirectToAction("ALLdetails");
        }
        public ActionResult ALLdetails()
        {
            var db = new ZeroHungerEntities();
            var product = db.Emoplyees.ToList();
            return View(product);

        }
    }
}