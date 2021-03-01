using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YeterZüccaciye.Models.Sınıflar;

namespace YeterZüccaciye.Controllers
{
    public class İstatistikController : Controller
    {
        // GET: İstatistik
        Context c = new Context();
        public ActionResult Index()
        {
            var value1 = c.Customers.Count().ToString();
            ViewBag.v1 = value1;
            var value2 = c.Products.Count().ToString();
            ViewBag.v2 = value2;
            var value3 = c.Staffs.Count().ToString();
            ViewBag.v3 = value3;
            var value4 = c.Categories.Count().ToString();
            ViewBag.v4 = value4;
            var value5 = c.Products.Sum(x => x.STOK).ToString();
            ViewBag.v5 = value5;
            var value6 = (from x in c.Products select x.BRAND).Distinct().Count().ToString();
            ViewBag.v6 = value6;
            var value7 = c.Products.Count(x => x.STOK <= 3).ToString();
            ViewBag.v7 = value7;
            var value8 = (from x in c.Products orderby x.SELLPRICE descending select x.PRODUCTNAME).FirstOrDefault();
            ViewBag.v8 = value8;
            var value9 = (from x in c.Products orderby x.SELLPRICE ascending select x.PRODUCTNAME).FirstOrDefault();
            ViewBag.v9 = value9;
            var value12 = c.Products.GroupBy(x => x.BRAND).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            ViewBag.v12 = value12;
            var value13 = c.Products.Where(u=>u.PRODUCTID ==( c.SalesMoves.GroupBy(x => x.ProductID).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault())).Select(k=>k.PRODUCTNAME).FirstOrDefault();
            ViewBag.v13 = value13;
            var value14 = c.SalesMoves.Sum(x => x.Total).ToString();
            ViewBag.v14 = value14;
            DateTime now = DateTime.Today;
            var value15 = c.SalesMoves.Count(x => x.SalesDate == now).ToString();
            ViewBag.v15 = value15;
            var value16 = c.SalesMoves.Where(x => x.SalesDate == now).Sum(y => (decimal?)y.Total).ToString();
            ViewBag.v16 = value16;
            return View();
        }
        public ActionResult SimpleTable()
        {
            var sorgu = from x in c.Customers
                        group x by x.CustomerCITY into g
                        select new GrupSınıf
                        {
                            City = g.Key,
                            Total = g.Count()
                        };
            return View(sorgu.ToList());
        }
        public PartialViewResult Parial1()
        {
            var sorgu2 = from x in c.Staffs
                         group x by x.DepartmentID into g
                         select new GrupSınıf2
                         {
                             Departman = g.Key,
                             Sayi = g.Count()
                         };
            return PartialView(sorgu2.ToList());
        }
        public PartialViewResult Parial2()
        {
            var sorgu3 = c.Customers.ToList();
            return PartialView(sorgu3);
        }
        public PartialViewResult Parial3()
        {
            var sorgu4 = c.Products.ToList();
            return PartialView(sorgu4);
        }
    }
}