using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using leave_salary.Models;
namespace leave_salary.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(leaveapp obj,string Yes)
        {
            if(Yes=="true")
            {
                obj.ApplyforLeave = "ON leave";
            }
            else
            {
                obj.ApplyforLeave = "Not on leave";
            }
            sampleEntities s = new sampleEntities();
            if (ModelState.IsValid)
            {
                s.leaveapps.Add(obj);
                s.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
            
        }
    }
}