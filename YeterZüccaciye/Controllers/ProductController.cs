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
    public class ProductController : Controller
    {
        // GET: Product
        Context c = new Context();
        public ActionResult Index(int page = 1)
        {
            var product = c.Products.Where(x => x.STATUS == true).ToList().ToPagedList(page, 5);
            return View(product);
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            List<SelectListItem> value1 = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CATEGORYNAME,
                                               Value = x.CATEGORYID.ToString()
                                           }).ToList();
            ViewBag.value2 = value1;  /* controldan view veri taşır*/
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product p)
        {
            c.Products.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProduct(int id)
        {
            var value = c.Products.Find(id);
            value.STATUS = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GoProduct(int id)
        {
            List<SelectListItem> value1 = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CATEGORYNAME,
                                               Value = x.CATEGORYID.ToString()
                                           }).ToList();
            ViewBag.value2 = value1;  /* controldan view veri taşır*/
            var productvalue = c.Products.Find(id);
            return View("GoProduct", productvalue);
        }
        public ActionResult UpdateProduct(Product p)
        {
            var prod = c.Products.Find(p.PRODUCTID);
            prod.GETPRICE = p.GETPRICE;
            prod.SELLPRICE = p.SELLPRICE;
            prod.STATUS = p.STATUS;
            prod.BRAND = p.BRAND;
            prod.CategoryID = p.CategoryID;
            prod.STOK = p.STOK;
            prod.PRODUCTNAME = p.PRODUCTNAME;
            prod.IMAGE = p.IMAGE;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ListProduct()
        {
            var value = c.Products.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult Buying(int id)
        {
            List<SelectListItem> value1 = (from x in c.Staffs.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.PersonelAD + " " + x.PersonelUSERNAME,
                                               Value = x.PersonelID.ToString()
                                           }).ToList();
            ViewBag.vals1 = value1;
            var value2 = c.Products.Find(id);
            ViewBag.vals2 = value2.PRODUCTID;
            ViewBag.vals3 = value2.SELLPRICE;
            return View();
        }
        [HttpPost]
        public ActionResult Buying(SalesMove sm)
        {
            sm.SalesDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            c.SalesMoves.Add(sm);
            c.SaveChanges();
            return RedirectToAction("Index","Sales");
        }
    }
}