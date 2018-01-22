using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BkReviewGitTest.Models;

namespace BkReviewGitTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() // Controller for the Index page
        {
            BookReviewDbEntities db = new BookReviewDbEntities();
            var bks = (from b in db.Books
                      select b).ToList();

            return View(bks); 
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