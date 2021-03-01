 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YeterZüccaciye.Models.Sınıflar;

namespace YeterZüccaciye.Controllers
{
    [Authorize]
    public class CargoController : Controller
    {
        // GET: Cargo
        Context c = new Context();  
        public ActionResult Index(string p)
        {
            var k=from x in c.CargoDetays select x;
            if (!string.IsNullOrEmpty(p))
            {
                k = k.Where(y => y.TakipKodu.Contains(p));
            }
            return View(k.ToList());
        }
        [HttpGet]
        public ActionResult AddCargo()
        {
            //rastgele kargo numarası
            Random rnd = new Random();
            string[] karakterler = { "A", "B", "C", "D" };
            int k1, k2, k3;
            k1 = rnd.Next(0, 4);
            k2 = rnd.Next(0, 4);
            k3 = rnd.Next(0, 4);
            int s1, s2, s3;
            s1 = rnd.Next(100, 1000);
            s2 = rnd.Next(10, 99);
            s3 = rnd.Next(10, 99);
            string kod = s1.ToString() + karakterler[k1] + s2 + karakterler[k2] + s3 + karakterler[k3];
            ViewBag.takipkod = kod;
            return View();
        }
        [HttpPost]
        public ActionResult AddCargo(CargoDetay d)
        {
            c.CargoDetays.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KargoTakip(string id)
        {
            var value = c.CargoTakips.Where(x =>x.TakipKodu  == id).ToList();
            return View(value);
        }
    }
}