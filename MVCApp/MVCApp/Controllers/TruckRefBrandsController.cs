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
    public class TruckRefBrandsController : Controller
    {
        private TruckDataEntities db = new TruckDataEntities();

        // GET: TruckRefBrands
        public ActionResult Index()
        {
            return View(db.TruckRefBrands.ToList());
        }

        // GET: TruckRefBrands/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TruckRefBrands truckRefBrands = db.TruckRefBrands.Find(id);
            if (truckRefBrands == null)
            {
                return HttpNotFound();
            }
            return View(truckRefBrands);
        }

        // GET: TruckRefBrands/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TruckRefBrands/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TruckRefBrandID,TruckRefBrandName")] TruckRefBrands truckRefBrands)
        {
            if (ModelState.IsValid)
            {
                db.TruckRefBrands.Add(truckRefBrands);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(truckRefBrands);
        }

        // GET: TruckRefBrands/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TruckRefBrands truckRefBrands = db.TruckRefBrands.Find(id);
            if (truckRefBrands == null)
            {
                return HttpNotFound();
            }
            return View(truckRefBrands);
        }

        // POST: TruckRefBrands/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TruckRefBrandID,TruckRefBrandName")] TruckRefBrands truckRefBrands)
        {
            if (ModelState.IsValid)
            {
                db.Entry(truckRefBrands).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(truckRefBrands);
        }

        // GET: TruckRefBrands/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TruckRefBrands truckRefBrands = db.TruckRefBrands.Find(id);
            if (truckRefBrands == null)
            {
                return HttpNotFound();
            }
            return View(truckRefBrands);
        }

        // POST: TruckRefBrands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TruckRefBrands truckRefBrands = db.TruckRefBrands.Find(id);
            db.TruckRefBrands.Remove(truckRefBrands);
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
