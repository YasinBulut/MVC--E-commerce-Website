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
    public class InvoiceController : Controller
    {
        // GET: Invoice
        Context c = new Context();
        public ActionResult Index(int page = 1)
        {
            var list = c.Invoices.ToList().ToPagedList(page, 5);
            return View(list);
        }
        [HttpGet]
        public ActionResult AddInvoices()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddInvoices(Invoice i)
        {
            c.Invoices.Add(i);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GoInvoices(int id)
        {
            var Inv= c.Invoices.Find(id);
            return View(Inv);
        }
        public ActionResult UpdateInvoice(Invoice f)
        {
            var fat = c.Invoices.Find(f.InvoiceID);
            fat.InvoiceSERİNO = f.InvoiceSERİNO;
            fat.InvoiceSIRANO = f.InvoiceSIRANO;
            fat.Hour = f.Hour;
            fat.Date = f.Date;
            fat.Selling = f.Selling;
            fat.Buyer = f.Buyer;
            fat.Tax = f.Tax;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult InvoirceExplanation(int id)
        {
            var value = c.Invoice_Parts.Where(x => x.InvoiceID == id).ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult AddPart()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPart(Invoice_part ip)
        {
            c.Invoice_Parts.Add(ip);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Dinamik()
        {
            Class2 cs = new Class2();
            cs.deger1 = c.Invoices.ToList();
            cs.deger2 = c.Invoice_Parts.ToList();
            return View(cs);
        }
    }
}