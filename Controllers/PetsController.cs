using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mc692617_MIS4200.DAL;
using mc692617_MIS4200.Models;

namespace mc692617_MIS4200.Controllers
{
    public class PetsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Pets
        public ActionResult Index()
        {
            var pets = db.Pets.Include(p => p.Owner);
            return View(pets.ToList());
        }

        // GET: Pets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pet pet = db.Pets.Find(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            return View(pet);
        }

        // GET: Pets/Create
        public ActionResult Create()
        {
            ViewBag.ownerID = new SelectList(db.Owners, "ownerID", "fullName");
            return View();
        }

        // POST: Pets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "petID,name,birthday,breed,weight,height,trackingNumber,photo,ownerID")] Pet pet)
        {
            if (ModelState.IsValid)
            {
                //HttpPostedFileBase file = Request.Files["UploadedImage"]; //(A) – see notes below
                //if (file != null && file.FileName != null && file.FileName != "") //(B)
                //{
                //    FileInfo fi = new FileInfo(file.FileName); //(C)
                //    if (fi.Extension != ".png" && fi.Extension != ".jpg" && fi.Extension != ".gif")//(D)
                //    {
                //        TempData["Errormsg"] = "Image File Extension is not valid"; //(E)
                //        return View(pet);
                //    }
                //    else
                //    {
                //        // this saves the file as the user’s ID and file extension
                //        pet.photo = pet.petID + fi.Extension; //(F)
                //        file.SaveAs(Server.MapPath("~/Images/" + pet.photo)); //(G)
                //    }
                //}
                db.Pets.Add(pet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ownerID = new SelectList(db.Owners, "ownerID", "fullName", pet.ownerID);
            return View(pet);
        }

        // GET: Pets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pet pet = db.Pets.Find(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            ViewBag.ownerID = new SelectList(db.Owners, "ownerID", "fullName", pet.ownerID);
            return View(pet);
        }

        // POST: Pets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "petID,name,birthday,breed,weight,height,trackingNumber,photo,ownerID")] Pet pet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ownerID = new SelectList(db.Owners, "ownerID", "fullName", pet.ownerID);
            return View(pet);
        }

        // GET: Pets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pet pet = db.Pets.Find(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            return View(pet);
        }

        // POST: Pets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pet pet = db.Pets.Find(id);
            db.Pets.Remove(pet);
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
