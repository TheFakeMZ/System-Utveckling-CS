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
    public class DiveCode1Controller : Controller
    {
        private DiveModel db = new DiveModel();

        // GET: DiveCode1
        public ActionResult Index()
        {
            return View(db.DiveCode1.ToList());
        }

        // GET: DiveCode1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiveCode1 diveCode1 = db.DiveCode1.Find(id);
            if (diveCode1 == null)
            {
                return HttpNotFound();
            }
            return View(diveCode1);
        }

        // GET: DiveCode1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DiveCode1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DiveCodeID,DiveGroup")] DiveCode1 diveCode1)
        {
            if (ModelState.IsValid)
            {
                db.DiveCode1.Add(diveCode1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(diveCode1);
        }

        // GET: DiveCode1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiveCode1 diveCode1 = db.DiveCode1.Find(id);
            if (diveCode1 == null)
            {
                return HttpNotFound();
            }
            return View(diveCode1);
        }

        // POST: DiveCode1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DiveCodeID,DiveGroup")] DiveCode1 diveCode1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diveCode1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(diveCode1);
        }

        // GET: DiveCode1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiveCode1 diveCode1 = db.DiveCode1.Find(id);
            if (diveCode1 == null)
            {
                return HttpNotFound();
            }
            return View(diveCode1);
        }

        // POST: DiveCode1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DiveCode1 diveCode1 = db.DiveCode1.Find(id);
            db.DiveCode1.Remove(diveCode1);
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
