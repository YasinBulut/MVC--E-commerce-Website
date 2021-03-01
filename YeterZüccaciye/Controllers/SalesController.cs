using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YeterZüccaciye.Models.Sınıflar;
using PagedList;
using PagedList.Mvc;

namespace YeterZüccaciye.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        Context c = new Context();
        public ActionResult Index(int page = 1)
        {
            var values = c.SalesMoves.ToList().ToPagedList(page, 5);
            return View(values);
        }
        [HttpGet]
        public ActionResult AddSales()
        {
            List<SelectListItem> value1 = (from x in c.Products.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.PRODUCTNAME,
                                               Value = x.PRODUCTID.ToString()
                                           }).ToList();
            List<SelectListItem> value2 = (from x in c.Customers.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CustomerNAME +" "+x.CustomerUSERNAME,
                                               Value = x.CustomerID.ToString()
                                           }).ToList();
            List<SelectListItem> value3 = (from x in c.Staffs.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.PersonelAD + " "+x.PersonelUSERNAME,
                                               Value = x.PersonelID.ToString()
                                           }).ToList();
            ViewBag.vals1 = value1;
            ViewBag.vals2 = value2;
            ViewBag.vals3 = value3;
            return View();
        }
        [HttpPost]
        public ActionResult AddSales(SalesMove s)
        {
            s.SalesDate =DateTime.Parse(DateTime.Now.ToShortDateString());
            c.SalesMoves.Add(s);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GoSales(int id)
        {
            List<SelectListItem> value1 = (from x in c.Products.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.PRODUCTNAME,
                                               Value = x.PRODUCTID.ToString()
                                           }).ToList();
            List<SelectListItem> value2 = (from x in c.Customers.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CustomerNAME + " " + x.CustomerUSERNAME,
                                               Value = x.CustomerID.ToString()
                                           }).ToList();
            List<SelectListItem> value3 = (from x in c.Staffs.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.PersonelAD + " " + x.PersonelUSERNAME,
                                               Value = x.PersonelID.ToString()
                                           }).ToList();
            ViewBag.vals1 = value1;
            ViewBag.vals2 = value2;
            ViewBag.vals3 = value3;
            var values = c.SalesMoves.Find(id);
            return View("GoSales",values);
        }
        public ActionResult UpdateSales(SalesMove p)
        {
            var val = c.SalesMoves.Find(p.SalesID);
            val.CustomerID = p.CustomerID;
            val.Amount = p.Amount;
            val.Price = p.Price;
            val.PersonelID = p.PersonelID;
            val.SalesDate = p.SalesDate;
            val.Total = p.Total;
            val.ProductID = p.ProductID;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SalesExplanation(int id)
        {
            var value = c.SalesMoves.Where(x => x.SalesID == id).ToList();
            return View(value);
        }
    }
}