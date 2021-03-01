using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YeterZüccaciye.Models.Sınıflar;

namespace YeterZüccaciye.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        Context c = new Context();
        public ActionResult Index()
        {
            var value = c.Products.ToList();
            return View(value);
        }
    }
}