using ICT_Project.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICT_Project.Controllers
{
    public class HomeController : Controller
    {
        private DataContext db = new DataContext();
       
        public ActionResult RMHome()

        {
         
           var RecordViewModel = from a in db.SdcDetails join b in db.Region on a.RegionName equals b.RegionName select new { SDC_Details = a, Region = b };

            //var Daily = from a in db.SdcDetails join b in db.Region on a.RegionName equals b.RegionName select a;
            
            return View();
        }
        public ActionResult ZDHome()
        { 
        
            return View();
        }
        public ActionResult UMHome()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}