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
    public class DivesController : Controller
    {
        private DiveModel db = new DiveModel();

        // GET: Dives
        public ActionResult Index()
        {
            var dives = db.Dives.Include(d => d.Competition1).Include(d => d.Competition2).Include(d => d.Competition3).Include(d => d.DiveChar51).Include(d => d.DiveChar52).Include(d => d.DiveChar53).Include(d => d.DiveCode11).Include(d => d.DiveCode12).Include(d => d.DiveCode13).Include(d => d.DiveCode21).Include(d => d.DiveCode22).Include(d => d.DiveCode23).Include(d => d.PlatformsHeight1).Include(d => d.PlatformsHeight2).Include(d => d.PlatformsHeight3);
            return View(dives.ToList());
        }

        // GET: Dives/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dive dive = db.Dives.Find(id);
            if (dive == null)
            {
                return HttpNotFound();
            }
            return View(dive);
        }

        // GET: Dives/Create
        public ActionResult Create()
        {
            ViewBag.Competition = new SelectList(db.Competitions, "CompetitionID", "Name");
            ViewBag.Competition = new SelectList(db.Competitions, "CompetitionID", "Name");
            ViewBag.Competition = new SelectList(db.Competitions, "CompetitionID", "Name");
            ViewBag.DiveChar5 = new SelectList(db.DiveChar5, "DiveCodeID", "BodyPosition");
            ViewBag.DiveChar5 = new SelectList(db.DiveChar5, "DiveCodeID", "BodyPosition");
            ViewBag.DiveChar5 = new SelectList(db.DiveChar5, "DiveCodeID", "BodyPosition");
            ViewBag.DiveCode1 = new SelectList(db.DiveCode1, "DiveCodeID", "DiveGroup");
            ViewBag.DiveCode1 = new SelectList(db.DiveCode1, "DiveCodeID", "DiveGroup");
            ViewBag.DiveCode1 = new SelectList(db.DiveCode1, "DiveCodeID", "DiveGroup");
            ViewBag.DiveCode2 = new SelectList(db.DiveCode2, "DiveCodeID", "DiveGroup");
            ViewBag.DiveCode2 = new SelectList(db.DiveCode2, "DiveCodeID", "DiveGroup");
            ViewBag.DiveCode2 = new SelectList(db.DiveCode2, "DiveCodeID", "DiveGroup");
            ViewBag.PlatformsHeight = new SelectList(db.PlatformsHeights, "PlatformsHeightID", "Height");
            ViewBag.PlatformsHeight = new SelectList(db.PlatformsHeights, "PlatformsHeightID", "Height");
            ViewBag.PlatformsHeight = new SelectList(db.PlatformsHeights, "PlatformsHeightID", "Height");
            return View();
        }

        // POST: Dives/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DiveID,Diver,Competition,DifficultyScore,DiveCode1,DiveCode2,DiveCode3,DiveCode4,DiveChar5,PlatformsHeight")] Dive dive)
        {
            if (ModelState.IsValid)
            {
                db.Dives.Add(dive);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Competition = new SelectList(db.Competitions, "CompetitionID", "Name", dive.Competition);
            ViewBag.Competition = new SelectList(db.Competitions, "CompetitionID", "Name", dive.Competition);
            ViewBag.Competition = new SelectList(db.Competitions, "CompetitionID", "Name", dive.Competition);
            ViewBag.DiveChar5 = new SelectList(db.DiveChar5, "DiveCodeID", "BodyPosition", dive.DiveChar5);
            ViewBag.DiveChar5 = new SelectList(db.DiveChar5, "DiveCodeID", "BodyPosition", dive.DiveChar5);
            ViewBag.DiveChar5 = new SelectList(db.DiveChar5, "DiveCodeID", "BodyPosition", dive.DiveChar5);
            ViewBag.DiveCode1 = new SelectList(db.DiveCode1, "DiveCodeID", "DiveGroup", dive.DiveCode1);
            ViewBag.DiveCode1 = new SelectList(db.DiveCode1, "DiveCodeID", "DiveGroup", dive.DiveCode1);
            ViewBag.DiveCode1 = new SelectList(db.DiveCode1, "DiveCodeID", "DiveGroup", dive.DiveCode1);
            ViewBag.DiveCode2 = new SelectList(db.DiveCode2, "DiveCodeID", "DiveGroup", dive.DiveCode2);
            ViewBag.DiveCode2 = new SelectList(db.DiveCode2, "DiveCodeID", "DiveGroup", dive.DiveCode2);
            ViewBag.DiveCode2 = new SelectList(db.DiveCode2, "DiveCodeID", "DiveGroup", dive.DiveCode2);
            ViewBag.PlatformsHeight = new SelectList(db.PlatformsHeights, "PlatformsHeightID", "Height", dive.PlatformsHeight);
            ViewBag.PlatformsHeight = new SelectList(db.PlatformsHeights, "PlatformsHeightID", "Height", dive.PlatformsHeight);
            ViewBag.PlatformsHeight = new SelectList(db.PlatformsHeights, "PlatformsHeightID", "Height", dive.PlatformsHeight);
            return View(dive);
        }

        // GET: Dives/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dive dive = db.Dives.Find(id);
            if (dive == null)
            {
                return HttpNotFound();
            }
            ViewBag.Competition = new SelectList(db.Competitions, "CompetitionID", "Name", dive.Competition);
            ViewBag.Competition = new SelectList(db.Competitions, "CompetitionID", "Name", dive.Competition);
            ViewBag.Competition = new SelectList(db.Competitions, "CompetitionID", "Name", dive.Competition);
            ViewBag.DiveChar5 = new SelectList(db.DiveChar5, "DiveCodeID", "BodyPosition", dive.DiveChar5);
            ViewBag.DiveChar5 = new SelectList(db.DiveChar5, "DiveCodeID", "BodyPosition", dive.DiveChar5);
            ViewBag.DiveChar5 = new SelectList(db.DiveChar5, "DiveCodeID", "BodyPosition", dive.DiveChar5);
            ViewBag.DiveCode1 = new SelectList(db.DiveCode1, "DiveCodeID", "DiveGroup", dive.DiveCode1);
            ViewBag.DiveCode1 = new SelectList(db.DiveCode1, "DiveCodeID", "DiveGroup", dive.DiveCode1);
            ViewBag.DiveCode1 = new SelectList(db.DiveCode1, "DiveCodeID", "DiveGroup", dive.DiveCode1);
            ViewBag.DiveCode2 = new SelectList(db.DiveCode2, "DiveCodeID", "DiveGroup", dive.DiveCode2);
            ViewBag.DiveCode2 = new SelectList(db.DiveCode2, "DiveCodeID", "DiveGroup", dive.DiveCode2);
            ViewBag.DiveCode2 = new SelectList(db.DiveCode2, "DiveCodeID", "DiveGroup", dive.DiveCode2);
            ViewBag.PlatformsHeight = new SelectList(db.PlatformsHeights, "PlatformsHeightID", "Height", dive.PlatformsHeight);
            ViewBag.PlatformsHeight = new SelectList(db.PlatformsHeights, "PlatformsHeightID", "Height", dive.PlatformsHeight);
            ViewBag.PlatformsHeight = new SelectList(db.PlatformsHeights, "PlatformsHeightID", "Height", dive.PlatformsHeight);
            return View(dive);
        }

        // POST: Dives/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DiveID,Diver,Competition,DifficultyScore,DiveCode1,DiveCode2,DiveCode3,DiveCode4,DiveChar5,PlatformsHeight")] Dive dive)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dive).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Competition = new SelectList(db.Competitions, "CompetitionID", "Name", dive.Competition);
            ViewBag.Competition = new SelectList(db.Competitions, "CompetitionID", "Name", dive.Competition);
            ViewBag.Competition = new SelectList(db.Competitions, "CompetitionID", "Name", dive.Competition);
            ViewBag.DiveChar5 = new SelectList(db.DiveChar5, "DiveCodeID", "BodyPosition", dive.DiveChar5);
            ViewBag.DiveChar5 = new SelectList(db.DiveChar5, "DiveCodeID", "BodyPosition", dive.DiveChar5);
            ViewBag.DiveChar5 = new SelectList(db.DiveChar5, "DiveCodeID", "BodyPosition", dive.DiveChar5);
            ViewBag.DiveCode1 = new SelectList(db.DiveCode1, "DiveCodeID", "DiveGroup", dive.DiveCode1);
            ViewBag.DiveCode1 = new SelectList(db.DiveCode1, "DiveCodeID", "DiveGroup", dive.DiveCode1);
            ViewBag.DiveCode1 = new SelectList(db.DiveCode1, "DiveCodeID", "DiveGroup", dive.DiveCode1);
            ViewBag.DiveCode2 = new SelectList(db.DiveCode2, "DiveCodeID", "DiveGroup", dive.DiveCode2);
            ViewBag.DiveCode2 = new SelectList(db.DiveCode2, "DiveCodeID", "DiveGroup", dive.DiveCode2);
            ViewBag.DiveCode2 = new SelectList(db.DiveCode2, "DiveCodeID", "DiveGroup", dive.DiveCode2);
            ViewBag.PlatformsHeight = new SelectList(db.PlatformsHeights, "PlatformsHeightID", "Height", dive.PlatformsHeight);
            ViewBag.PlatformsHeight = new SelectList(db.PlatformsHeights, "PlatformsHeightID", "Height", dive.PlatformsHeight);
            ViewBag.PlatformsHeight = new SelectList(db.PlatformsHeights, "PlatformsHeightID", "Height", dive.PlatformsHeight);
            return View(dive);
        }

        // GET: Dives/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dive dive = db.Dives.Find(id);
            if (dive == null)
            {
                return HttpNotFound();
            }
            return View(dive);
        }

        // POST: Dives/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dive dive = db.Dives.Find(id);
            db.Dives.Remove(dive);
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
