
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using YeterZüccaciye.Models.Sınıflar;

namespace YeterZüccaciye.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult Partial1()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Partial1(Customers cus)
        {
            c.Customers.Add(cus);
            c.SaveChanges();
            return PartialView();
        }
        [HttpGet]
        public ActionResult CustomerLogin1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CustomerLogin1(Customers cus)
        {
            var value = c.Customers.FirstOrDefault(x => x.CustomerMAIL == cus.CustomerMAIL && x.CustomerPassword == cus.CustomerPassword);
            if (value != null)
            {
                FormsAuthentication.SetAuthCookie(value.CustomerMAIL, false);
                Session["CustomerMAIL"] = value.CustomerMAIL.ToString();
                return RedirectToAction("Index", "CustomerPanel");
            }
            else
            {
                return RedirectToAction("Index", "CustomerPanel");
            }

        }
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin p)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.UserNAME == p.UserNAME && x.Password == p.Password);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.UserNAME, false);
                Session["UserNAME"] = bilgiler.UserNAME.ToString();
                return RedirectToAction("Index", "Category");
            }
            else
            {
                return RedirectToAction("Index", "Category");
            }
        }
    }
}