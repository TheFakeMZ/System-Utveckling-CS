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
    public class DiveCode2Controller : Controller
    {
        private DiveModel db = new DiveModel();

        // GET: DiveCode2
        public ActionResult Index()
        {
            return View(db.DiveCode2.ToList());
        }

        // GET: DiveCode2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiveCode2 diveCode2 = db.DiveCode2.Find(id);
            if (diveCode2 == null)
            {
                return HttpNotFound();
            }
            return View(diveCode2);
        }

        // GET: DiveCode2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DiveCode2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DiveCodeID,DiveGroup")] DiveCode2 diveCode2)
        {
            if (ModelState.IsValid)
            {
                db.DiveCode2.Add(diveCode2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(diveCode2);
        }

        // GET: DiveCode2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiveCode2 diveCode2 = db.DiveCode2.Find(id);
            if (diveCode2 == null)
            {
                return HttpNotFound();
            }
            return View(diveCode2);
        }

        // POST: DiveCode2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DiveCodeID,DiveGroup")] DiveCode2 diveCode2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diveCode2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(diveCode2);
        }

        // GET: DiveCode2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiveCode2 diveCode2 = db.DiveCode2.Find(id);
            if (diveCode2 == null)
            {
                return HttpNotFound();
            }
            return View(diveCode2);
        }

        // POST: DiveCode2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DiveCode2 diveCode2 = db.DiveCode2.Find(id);
            db.DiveCode2.Remove(diveCode2);
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
