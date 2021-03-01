using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YeterZüccaciye.Models.Sınıflar;
using PagedList;
using PagedList.Mvc;
using System.IO;

namespace YeterZüccaciye.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        Context c = new Context();
        public ActionResult Index(int page = 1)
        {
            var value = c.Staffs.ToList().ToPagedList(page, 5);
            return View(value);
        }
        [HttpGet]
        public ActionResult AddStaff()
        {
            List<SelectListItem> value1 = (from x in c.Departments.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.DepartmentNAME,
                                               Value = x.DepartmentID.ToString()
                                           }).ToList();
            ViewBag.value2 = value1;  /* controldan view veri taşır*/
            return View();
        }
        [HttpPost]
        public ActionResult AddStaff(Staff s)
        {
            if (Request.Files.Count > 0)
            {
                string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
                string uzanti = Path.GetExtension(Request.Files[0].FileName);
                string yol = "~/Image/" + dosyaadi + uzanti;
                Request.Files[0].SaveAs(Server.MapPath(yol));
                s.PersonelIMAGE = "/Image/" + dosyaadi + uzanti;
            }
            c.Staffs.Add(s);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GoStaff(int id)
        {

            List<SelectListItem> value1 = (from x in c.Departments.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.DepartmentNAME,
                                               Value = x.DepartmentID.ToString()
                                           }).ToList();
            ViewBag.value2 = value1;  /* controldan view veri taşır*/
            var prs = c.Staffs.Find(id);
            return View("GoStaff", prs);
        }
        public ActionResult UpdateStaff(Staff p)
        {
            var prsn = c.Staffs.Find(p.PersonelID);
            prsn.PersonelAD = p.PersonelAD;
            prsn.PersonelUSERNAME = p.PersonelUSERNAME;
            prsn.PersonelIMAGE = p.PersonelIMAGE;
            prsn.DepartmentID = p.DepartmentID;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult PersonelList()
        {
            var sorgu5 = c.Staffs.ToList();
            return View(sorgu5);
        }
    }
}