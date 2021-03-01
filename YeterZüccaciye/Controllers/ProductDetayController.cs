using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YeterZüccaciye.Models.Sınıflar;

namespace YeterZüccaciye.Controllers
{
    public class ProductDetayController : Controller
    {
        // GET: ProductDetay
        Context c = new Context();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            //var value = c.Products.Where(x=>x.PRODUCTID==1).ToList();
            cs.Value1 = c.Products.Where(x => x.PRODUCTID == 1).ToList();
            cs.Value2 = c.Detays.Where(y => y.DetayID == 1).ToList();
            return View(cs);
        }
        public ActionResult Index2()
        {
            var value = c.Products.ToList();
            return View(value);
        }
    }
}