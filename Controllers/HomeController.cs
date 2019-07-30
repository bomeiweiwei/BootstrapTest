using BootstrapTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapTest.Controllers
{
    public class HomeController : Controller
    {
        private NorthwindEntities db = new NorthwindEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Table1()
        {
            return View(db.Products.ToList());
        }

        public ActionResult BookInfo()
        {
            return View();
        }

        public ActionResult CreateBook()
        {
            return View();
        }

        public ActionResult MediaInfo()
        {
            return View();
        }

        public ActionResult ListGroup()
        {
            return View();
        }

        public ActionResult ButtonGroup()
        {
            return View();
        }

        public ActionResult NavTest()
        {
            return View();
        }

        public ActionResult NavBarTest()
        {
            return View();
        }

        public ActionResult CardTest()
        {
            return View();
        }

        public ActionResult Search(SearchModel search)
        {
            ViewBag.SearchInfo = search.SearchInfo;
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}