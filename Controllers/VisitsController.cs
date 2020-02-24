using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mc692617_MIS4200.DAL;
using mc692617_MIS4200.Models;

namespace mc692617_MIS4200.Controllers
{
    public class VisitsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Visits
        public ActionResult Index()
        {
            var visits = db.Visits.Include(v => v.Pet).Include(v => v.Vet);
            return View(visits.ToList());
        }

        // GET: Visits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visits visits = db.Visits.Find(id);
            if (visits == null)
            {
                return HttpNotFound();
            }
            return View(visits);
        }

        // GET: Visits/Create
        public ActionResult Create()
        {
            ViewBag.petID = new SelectList(db.Pets, "petID", "name");
            ViewBag.vetID = new SelectList(db.Vets, "vetID", "fullName");
            return View();
        }

        // POST: Visits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "visitID,vetID,petID,dateTime,description")] Visits visits)
        {
            if (ModelState.IsValid)
            {
                db.Visits.Add(visits);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.petID = new SelectList(db.Pets, "Pet Name", "name", visits.petID);
            ViewBag.vetID = new SelectList(db.Vets, "vetID", "fullName", visits.vetID);
            return View(visits);
        }

        // GET: Visits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visits visits = db.Visits.Find(id);
            if (visits == null)
            {
                return HttpNotFound();
            }
            ViewBag.petID = new SelectList(db.Pets, "petID", "name", visits.petID);
            ViewBag.vetID = new SelectList(db.Vets, "vetID", "fullName", visits.vetID);
            return View(visits);
        }

        // POST: Visits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "visitID,vetID,petID,dateTime,description")] Visits visits)
        {
            if (ModelState.IsValid)
            {
                db.Entry(visits).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.petID = new SelectList(db.Pets, "petID", "name", visits.petID);
            ViewBag.vetID = new SelectList(db.Vets, "vetID", "fullName", visits.vetID);
            return View(visits);
        }

        // GET: Visits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visits visits = db.Visits.Find(id);
            if (visits == null)
            {
                return HttpNotFound();
            }
            return View(visits);
        }

        // POST: Visits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Visits visits = db.Visits.Find(id);
            db.Visits.Remove(visits);
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
