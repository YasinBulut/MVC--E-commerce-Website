using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using YeterZüccaciye.Models.Sınıflar;

namespace YeterZüccaciye.Controllers
{
    public class CustomerPanelController : Controller
    {
        // GET: CustomerPanel
        Context c = new Context();  
        public ActionResult Index()
        {
            var mail = (string)Session["CustomerMAIL"];
            var value = c.Messages.Where(x => x.Alici == mail).ToList();
            ViewBag.m = mail;
            var mailid = c.Customers.Where(x => x.CustomerMAIL == mail).Select(y => y.CustomerID).FirstOrDefault();
            ViewBag.mid = mailid;
            var toplamsatis = c.SalesMoves.Where(x => x.CustomerID == mailid).Count();
            ViewBag.toplamsatis = toplamsatis;
            var satistutar = c.SalesMoves.Where(x => x.CustomerID == mailid).Sum(y => y.Total);
            ViewBag.total = satistutar;
            var urunsayisi = c.SalesMoves.Where(x => x.CustomerID == mailid).Sum(y => y.Amount);
            ViewBag.adet = urunsayisi;
            var adsoyad = c.Customers.Where(x => x.CustomerMAIL == mail).Select(y => y.CustomerNAME + " " + y.CustomerUSERNAME).FirstOrDefault();
            ViewBag.name = adsoyad;
            return View(value);
        }
        public ActionResult Orders()
        {
            var mail = (string)Session["CustomerMAIL"];
            var id = c.Customers.Where(x => x.CustomerMAIL == mail.ToString()).Select(y => y.CustomerID).FirstOrDefault();
            var value2 = c.SalesMoves.Where(x => x.CustomerID == id).ToList();
            return View(value2);
        }
        public ActionResult GelenMessage()
        {
            var mail = (string)Session["CustomerMail"];
            var message = c.Messages.Where(x=>x.Alici==mail).ToList();
            var gidenmessage = c.Messages.Count(x => x.Gönderen == mail).ToString();
            ViewBag.d2 = gidenmessage;
            var gelenmessage = c.Messages.Count(x => x.Alici == mail).ToString();
            ViewBag.d1 = gelenmessage;
            return View(message);
        }
        public ActionResult GidenMessage()
        {
            var mail = (string)Session["CustomerMail"];
            var message = c.Messages.Where(x => x.Gönderen == mail).ToList();
            var gidenmessage = c.Messages.Count(x => x.Gönderen == mail).ToString();
            ViewBag.d2 = gidenmessage;
            var gelenmessage = c.Messages.Count(x => x.Alici == mail).ToString();
            ViewBag.d1 = gelenmessage;
            return View(message);
        }
        public ActionResult MessageDetay(int id)
        {
            var values = c.Messages.Where(x => x.MessageID == id).ToList();
            var mail = (string)Session["CustomerMail"];
            var gidenmessage = c.Messages.Count(x => x.Gönderen == mail).ToString();
            ViewBag.d2 = gidenmessage;
            var gelenmessage = c.Messages.Count(x => x.Alici == mail).ToString();
            ViewBag.d1 = gelenmessage;
            return View(values);
        }
        [HttpGet]
        public ActionResult YeniMessage()
        {
            var mail = (string)Session["CustomerMail"];
            var gidenmessage = c.Messages.Count(x => x.Gönderen == mail).ToString();
            ViewBag.d2 = gidenmessage;
            var gelenmessage = c.Messages.Count(x => x.Alici == mail).ToString();
            ViewBag.d1 = gelenmessage;
            return View();
        }
        [HttpPost]
        public ActionResult YeniMessage(Message m)
        {
            var mail = (string)Session["CustomerMail"];
            m.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            m.Gönderen = mail;
            c.Messages.Add(m);
            c.SaveChanges();
            return View();
        }
        public ActionResult CargoTakip(string p)
        {
            var k = from x in c.CargoDetays select x;
                k = k.Where(y => y.TakipKodu.Contains(p));
            return View(k.ToList());
        }
        public ActionResult CargoDetay(string id)
        {
            var value = c.CargoTakips.Where(x => x.TakipKodu == id).ToList();
            return View(value);
        }
        public ActionResult Exit()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
        public PartialViewResult Partial1()
        {
            var mail = (string)Session["CustomerMail"];
            var id = c.Customers.Where(x => x.CustomerMAIL == mail).Select(y => y.CustomerID).FirstOrDefault();
            var cusbul = c.Categories.Find(id);
            return PartialView("Partial1", cusbul);
        }
    }
}