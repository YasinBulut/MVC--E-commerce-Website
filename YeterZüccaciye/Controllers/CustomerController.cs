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
    public class CustomerController : Controller
    {
        // GET: Customer
        Context c = new Context();
        public ActionResult Index(int page = 1)
        {
            var value = c.Customers.Where(x=>x.Status==true).ToList().ToPagedList(page, 5);
            return View(value);
        }
        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCustomer(Customers p)
        {
            p.Status = true;
            c.Customers.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCustomer(int id)
        {
            var cr = c.Customers.Find(id);
            cr.Status = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GoCustomer(int id)
        {
            var cr = c.Customers.Find(id);
            return View("GoCustomer", cr);
        }
        public ActionResult UpdateCustomer(Customers b)
        {
            var cus = c.Customers.Find(b.CustomerID);
            cus.CustomerNAME = b.CustomerNAME;
            cus.CustomerUSERNAME = b.CustomerUSERNAME;
            cus.CustomerCITY = b.CustomerCITY;
            cus.CustomerMAIL = b.CustomerMAIL;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CustomerSales(int id)
        {
            var value = c.SalesMoves.Where(x => x.CustomerID == id).ToList();
            var cs = c.Customers.Where(x => x.CustomerID == id).Select(y => y.CustomerNAME + " " + y.CustomerUSERNAME).FirstOrDefault();
            ViewBag.cust = cs;
            return View(value);
        }
    }
}