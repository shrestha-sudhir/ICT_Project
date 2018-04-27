using System;
using System.Collections.Generic;

using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ICT_Project.Datas;
using ICT_Project.Models.DBC;

namespace ICT_Project.Controllers
{
    public class DailyDatasController : Controller
    {
        private DataContext db = new DataContext();

        // GET: DailyDatas
        public ActionResult Index()
        {
            return View(db.Dailydata.ToList());
        }

        // GET: DailyDatas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyData dailyData = db.Dailydata.Find(id);
            if (dailyData == null)
            {
                return HttpNotFound();
            }
            return View(dailyData);
        }

        // GET: DailyDatas/Create
        public ActionResult Create()
        {
            ViewBag.SdcDetails = from a in db.SdcDetails select a;
            ViewBag.Notice = from a in db.Notices select a; ;
            return View();
        }

        // POST: DailyDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DailyDataID,Date,WorkingSDC,Appointments,Presentations,SuccessfulPresentations,Attendance,Members,NinthKyus,Classes,EquipmentSales,Interviews,RegionalName,ZoneName")] DailyData dailyData)
        {
            if (ModelState.IsValid)
            {
                db.Dailydata.Add(dailyData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dailyData);
        }

        // GET: DailyDatas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyData dailyData = db.Dailydata.Find(id);
            if (dailyData == null)
            {
                return HttpNotFound();
            }
            return View(dailyData);
        }

        // POST: DailyDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DailyDataID,Date,WorkingSDC,Appointments,Presentations,SuccessfulPresentations,Attendance,Members,NinthKyus,Classes,EquipmentSales,Interviews,RegionalID,ZoneID")] DailyData dailyData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dailyData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dailyData);
        }

        // GET: DailyDatas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyData dailyData = db.Dailydata.Find(id);
            if (dailyData == null)
            {
                return HttpNotFound();
            }
            return View(dailyData);
        }

        // POST: DailyDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DailyData dailyData = db.Dailydata.Find(id);
            db.Dailydata.Remove(dailyData);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
