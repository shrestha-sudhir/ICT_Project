using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;

using ICTProject.Data;
using ICTProject.Models.DBC;

namespace ICTProject.Controllers
{
    public class DropReportsController : Controller
    {

        private DbcContext db = new DbcContext();

        // GET: Drop3
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult attendanceTracker()
        {
            return View();
        }

        public ActionResult intPerformance()
        {
            return View();
        }
        public ActionResult nightlyPerformance()
        {
            return View();
        }
        public ActionResult top10country()
        {
            return View();
        }
        public ActionResult top10World()
        {
            return View();
        }
        public ActionResult topGunsNightly()
        {
            return View();
        }
        public ActionResult weeklyBestRegion()
        {
            return View();
        }
        public ActionResult weeklyPerformance()
        {
            return View();
        }
        public ActionResult weeklySalesStats()
        {

            int id = 1;

            // LINQ
            DailyData dailyData = db.DailyData.Find(id);

            return View();
        }
    }
}