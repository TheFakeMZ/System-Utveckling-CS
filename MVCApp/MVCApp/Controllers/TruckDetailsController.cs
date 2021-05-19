using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{ 
    public class TruckDetailsController : Controller
    {
       

        private TruckDataEntities db = new TruckDataEntities();

        // GET: TruckDetails
        public ActionResult Index()
        {
            var truckDetail = db.TruckDetail.Include(t => t.TruckRefBrands);
            return View(truckDetail.ToList());
        }

        // GET: TruckDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TruckDetail truckDetail = db.TruckDetail.Find(id);
            if (truckDetail == null)
            {
                return HttpNotFound();
            }
            return View(truckDetail);
        }

        // GET: TruckDetails/Create
        public ActionResult Create()
        {
            ViewBag.TruckBrandID = new SelectList(db.TruckRefBrands, "TruckRefBrandID", "TruckRefBrandName");
            return View();
        }

        // POST: TruckDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TruckID,TruckDescription,TruckBrandID,TruckColor")] TruckDetail truckDetail)
        {
            if (ModelState.IsValid)
            {
                db.TruckDetail.Add(truckDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TruckBrandID = new SelectList(db.TruckRefBrands, "TruckRefBrandID", "TruckRefBrandName", truckDetail.TruckBrandID);
            return View(truckDetail);
        }

        // GET: TruckDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TruckDetail truckDetail = db.TruckDetail.Find(id);
            if (truckDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.TruckBrandID = new SelectList(db.TruckRefBrands, "TruckRefBrandID", "TruckRefBrandName", truckDetail.TruckBrandID);
            return View(truckDetail);
        }

        // POST: TruckDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TruckID,TruckDescription,TruckBrandID,TruckColor")] TruckDetail truckDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(truckDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TruckBrandID = new SelectList(db.TruckRefBrands, "TruckRefBrandID", "TruckRefBrandName", truckDetail.TruckBrandID);
            return View(truckDetail);
        }

        // GET: TruckDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TruckDetail truckDetail = db.TruckDetail.Find(id);
            if (truckDetail == null)
            {
                return HttpNotFound();
            }
            return View(truckDetail);
        }

        // POST: TruckDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TruckDetail truckDetail = db.TruckDetail.Find(id);
            db.TruckDetail.Remove(truckDetail);
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
