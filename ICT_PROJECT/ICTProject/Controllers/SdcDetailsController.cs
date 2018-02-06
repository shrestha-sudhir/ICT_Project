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

namespace ICTProject.Controllers
{
    public class SdcDetailsController : Controller
    {
        private DbcContext db = new DbcContext();

        // GET: SdcDetails
        public ActionResult Index()
        {

            return View(db.SdcDetails.ToList());
        } 

        // GET: SdcDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SdcDetails sdcDetails = db.SdcDetails.Find(id);
            if (sdcDetails == null)
            {
                return HttpNotFound();
            }
            return View(sdcDetails);
        }

        // GET: SdcDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SdcDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SdcDetailsId,FirstName,LastName,DateAdded,IsTeamCoordinator,IsFullTime")] SdcDetails sdcDetails)
        {
            if (ModelState.IsValid)
            {
                db.SdcDetails.Add(sdcDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sdcDetails);
        }

        // GET: SdcDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SdcDetails sdcDetails = db.SdcDetails.Find(id);
            if (sdcDetails == null)
            {
                return HttpNotFound();
            }
            return View(sdcDetails);
        }

        // POST: SdcDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SdcDetailsId,FirstName,LastName,DateAdded,IsTeamCoordinator,IsFullTime")] SdcDetails sdcDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sdcDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sdcDetails);
        }

        // GET: SdcDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SdcDetails sdcDetails = db.SdcDetails.Find(id);
            if (sdcDetails == null)
            {
                return HttpNotFound();
            }
            return View(sdcDetails);
        }

        // POST: SdcDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SdcDetails sdcDetails = db.SdcDetails.Find(id);
            db.SdcDetails.Remove(sdcDetails);
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
