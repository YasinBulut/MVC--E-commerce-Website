using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YeterZüccaciye.Models.Sınıflar;

namespace YeterZüccaciye.Controllers
{
    public class YapilacakController : Controller
    {
        // GET: Yapilacak
        Context c = new Context();
        public ActionResult Index()
        {
            var value1 = c.Customers.Count().ToString();
            ViewBag.v1 = value1;
            var value2 = c.Products.Count().ToString();
            ViewBag.v2 = value2;
            var value3 = c.Categories.Count().ToString();
            ViewBag.v3 = value3;
            var value4 = (from x in c.Customers select x.CustomerCITY).Distinct().Count().ToString();
            ViewBag.v4 = value4;


            var yapilacaklar = c.Yapilacaks.ToList();
            return View(yapilacaklar);
        }
    }
}