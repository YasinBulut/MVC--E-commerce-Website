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
    public class CategoryController : Controller
    {
        // GET: Category
        Context c = new Context();
        public ActionResult Index(int page=1)
        {
            var value = c.Categories.ToList().ToPagedList(page ,5);
            return View(value);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category z)
        {
            c.Categories.Add(z);
            c.SaveChanges(); // executenonquery 
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCategory(int id)
        {
            var cat = c.Categories.Find(id);
            c.Categories.Remove(cat);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GoCategory(int id)
        {
            var cat = c.Categories.Find(id);
            return View("GoCategory",cat);
        }
        public ActionResult UpdateCategory(Category y)
        {
            var cat = c.Categories.Find(y.CATEGORYID);
            cat.CATEGORYNAME = y.CATEGORYNAME;
            c.SaveChanges();
            return RedirectToAction("Index");  
        }
    }
}