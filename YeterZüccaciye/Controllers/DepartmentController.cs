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
    public class DepartmentController : Controller
    {
        // GET: Department
        Context c = new Context();
        public ActionResult Index(int page = 1)
        {
            var value = c.Departments.Where(x => x.Status == true).ToList().ToPagedList(page, 5);
            return View(value);
        }
        [HttpGet]
        public ActionResult AddDepartment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDepartment(Department d)
        {
            c.Departments.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteDepartment(int id)
        {
            var dep = c.Departments.Find(id);
            dep.Status = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GoDepartment(int id)
        {
            var dep = c.Departments.Find(id);
            return View("GoDepartment", dep);
        }
        public ActionResult UpdateDepartment(Department d)
        {
            var dep = c.Departments.Find(d.DepartmentID);
            dep.DepartmentNAME = d.DepartmentNAME;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ExplanationDepartment(int id)
        {
            var value = c.Staffs.Where(x => x.DepartmentID == id).ToList();
            var dep = c.Departments.Where(x => x.DepartmentID == id).Select(y => y.DepartmentNAME).FirstOrDefault();
            ViewBag.d = dep;
            return View(value);
        }
        public ActionResult DepartmentStaffSales(int id)
        {
            var value = c.SalesMoves.Where(x => x.PersonelID == id).ToList();
            var per = c.Staffs.Where(x => x.PersonelID == id).Select(y => y.PersonelAD + " " + y.PersonelUSERNAME).FirstOrDefault();
            ViewBag.dp = per;
            return View(value);
        }

    }
}
