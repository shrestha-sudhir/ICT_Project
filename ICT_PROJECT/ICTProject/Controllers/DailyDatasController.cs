using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ICTProject.Data;
using ICTProject.Models.DBC;

namespace ICTProject.Views
{
    public class DailyDatasController : Controller
    {
        private DbcContext db = new DbcContext();
        public ActionResult View1()
        {
            return View();
        }

        // GET: DailyDatas
        public ActionResult Index()
        {

            var data = from a in db.DailyData select a;

            //            var innerJoinQuery =
            //from category in categories
            //join prod in products on category.ID equals prod.CategoryID
            //select new { ProductName = prod.Name, Category = category.Name };

            //var detail = (from dd in db.DailyData join x in db.SdcDetails
            //            on dd.SdcDetailsID equals x.SdcDetailsId select new { dd, x }).ToList();
            return View(data);
        }

        // GET: DailyDatas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // LINQ
            DailyData dailyData = db.DailyData.Find(id);

            // lambda
           // dailyData = db.DailyData.Where(p => p.DailyDataId == id).FirstOrDefault();

            // LINQ
            //dailyData = (from p in db.DailyData where p.DailyDataId == id select p).FirstOrDefault();


            if (dailyData == null){
                return HttpNotFound();
            }
            
            return View(dailyData);
        }

        // GET: DailyDatas/Create
        public ActionResult Create()
        {
            var name = (from m in db.SdcDetails select new { m = m.FirstName + " " + m.LastName}).ToList();
            var comt = db.PDTopics;
            var sdc = db.SdcDetails.ToList();
            ViewBag.dailydata = sdc;
            ViewBag.comment = comt;

            return View();
        }

        // POST: DailyDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DailyDataId,Date,WorkingSDC,Appointments,Presentations,SuccessfulPresentations,Attendance,Members,NinthKyus,Classes,EquipmentSales,Interviews")] DailyData dailyData)
        {
            if (ModelState.IsValid)
            {
                db.DailyData.Add(dailyData);
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
            DailyData dailyData = db.DailyData.Find(id);
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
        public ActionResult Edit([Bind(Include = "DailyDataId,Date,WorkingSDC,Appointments,Presentations,SuccessfulPresentations,Attendance,Members,NinthKyus,Classes,EquipmentSales,Interviews")] DailyData dailyData)
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
            DailyData dailyData = db.DailyData.Find(id);
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
            DailyData dailyData = db.DailyData.Find(id);
            db.DailyData.Remove(dailyData);
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
