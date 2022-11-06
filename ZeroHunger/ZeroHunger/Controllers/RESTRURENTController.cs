using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.DB;

namespace ZeroHunger.Controllers
{
    public class RESTRURENTController : Controller
    {
        // GET: RESTRURENT
        public ActionResult Index()
        {
            var db = new ZeroHungerEntities();
            var product = db.Restrurants.ToList();
            return View(product);

        }
        [HttpGet]
       
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Dashboard book)
        {

            //add book to db
            var db = new ZeroHungerEntities();
            db.Dashboards.Add(book);
            db.SaveChanges();
            return RedirectToAction("VDASBOARD");
        }
        public ActionResult VDASBOARD()
        {
            var db = new ZeroHungerEntities();
            var product = db.Dashboards.ToList();
            return View(product);

        }
    }
}