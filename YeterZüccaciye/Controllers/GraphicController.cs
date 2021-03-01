using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using YeterZüccaciye.Models.Sınıflar;

namespace YeterZüccaciye.Controllers
{
    public class GraphicController : Controller
    {
        // GET: Graphic
        Context c = new Context();
        public ActionResult Index()
        {
            ArrayList xvalue = new ArrayList();
            ArrayList yvalue = new ArrayList();
            var sonuc = c.Products.ToList();
            sonuc.ToList().ForEach(x => xvalue.Add(x.PRODUCTNAME));
            sonuc.ToList().ForEach(y => yvalue.Add(y.STOK));
            var graphic = new Chart(width: 1500, height: 1500)
                .AddTitle("Stoklar")
                .AddSeries(chartType: "Column", name: "Stok", xValue: xvalue, yValues: yvalue);  
            return File(graphic.ToWebImage().GetBytes(),"image/jpeg");
        }
    }
}