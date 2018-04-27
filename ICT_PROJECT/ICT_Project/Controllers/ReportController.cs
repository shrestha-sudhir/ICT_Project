using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ICT_Project.Datas;
using ICT_Project.Models.DBC;
using System.Data.Entity;

namespace ICT_Project.Controllers
{
    public class ReportController : Controller
        
    {
        private DataContext db = new DataContext();
        // GET: Report
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AttendanceTracker()
        {
            return View();
        }

        public ActionResult IntPerformance()
        {
            return View();
        }
        public ActionResult NightlyPerformance()
        {
            return View();
        }
        public ActionResult TopTenCountry()
        {
            return View();
        }
        public ActionResult TopTenWorld()
        {
            return View();
        }
        public ActionResult TopGunsNightly()
        {
            return View();
        }
        public ActionResult WeeklyBestRegion()
        {
            return View();
        }
        public ActionResult WeeklyPerformance()
        {
            return View();
        }
        public ActionResult WeeklySalesStats()
        {

            int id = 1;

            // LINQ
            DailyData dailyData = db.Dailydata.Find(id);

            return View();
        }
    }
}