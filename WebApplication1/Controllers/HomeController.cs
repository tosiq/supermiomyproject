using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        adminEntities db = new adminEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult about()
        {
            return View();
        }
        public ActionResult practice_area()
        {
            return View();
        }
        public ActionResult practice_single()
        {
            return View();
        }

        public ActionResult attorneys()
        {
            return View();
        }

        public ActionResult case_results()
        {
            return View();
        }
        public ActionResult case_detail()
        {
            return View();
        }
        public ActionResult blog()
        {
            return View();
        }

        public ActionResult contact()
        {
            return View();
        }
        public ActionResult dashboard()
        {
            return View();
        }
        public ActionResult signin()
        {
            return View();
        }
        public ActionResult faq()
        {
            return View();
        }
        public ActionResult form()
        {
            return View();
        }
        public ActionResult form1()
        {
            return View();
        }
        public ActionResult form2()
        {
            return View();
        }
        public ActionResult form3()
        {
            return View();
        }
        public ActionResult form4()
        {
            return View();
        }
        public ActionResult form0()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Email, string Password)
        {
            var user = db.adms.Where(x => x.username == Email && x.password == Password).FirstOrDefault();
            if (user == null)
            {
                return RedirectToAction("signin", "Home");
            }
            else
            {
                return RedirectToAction("dashboard", "Home");

            }
        }






    }
}