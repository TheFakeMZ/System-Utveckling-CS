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
    public class DiveChar5Controller : Controller
    {
        private DiveModel db = new DiveModel();

        // GET: DiveChar5
        public ActionResult Index()
        {
            return View(db.DiveChar5.ToList());
        }

        // GET: DiveChar5/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiveChar5 diveChar5 = db.DiveChar5.Find(id);
            if (diveChar5 == null)
            {
                return HttpNotFound();
            }
            return View(diveChar5);
        }

        // GET: DiveChar5/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DiveChar5/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DiveCodeID,BodyPosition")] DiveChar5 diveChar5)
        {
            if (ModelState.IsValid)
            {
                db.DiveChar5.Add(diveChar5);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(diveChar5);
        }

        // GET: DiveChar5/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiveChar5 diveChar5 = db.DiveChar5.Find(id);
            if (diveChar5 == null)
            {
                return HttpNotFound();
            }
            return View(diveChar5);
        }

        // POST: DiveChar5/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DiveCodeID,BodyPosition")] DiveChar5 diveChar5)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diveChar5).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(diveChar5);
        }

        // GET: DiveChar5/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiveChar5 diveChar5 = db.DiveChar5.Find(id);
            if (diveChar5 == null)
            {
                return HttpNotFound();
            }
            return View(diveChar5);
        }

        // POST: DiveChar5/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DiveChar5 diveChar5 = db.DiveChar5.Find(id);
            db.DiveChar5.Remove(diveChar5);
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
