using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sorties.Models;
using Sorties.Models.Repository;

namespace Sorties.Controllers
{
    public class LocalitesController : Controller
    {
        private BddContextSorties db = new BddContextSorties();

        // GET: Localites
        public ActionResult Index()
        {
            return View(db.Localites.ToList());
        }

        // GET: Localites/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Localites localites = db.Localites.Find(id);
            if (localites == null)
            {
                return HttpNotFound();
            }
            return View(localites);
        }

        // GET: Localites/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Localites/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,cp,localite")] Localites localites)
        {
            if (ModelState.IsValid)
            {
                db.Localites.Add(localites);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(localites);
        }

        // GET: Localites/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Localites localites = db.Localites.Find(id);
            if (localites == null)
            {
                return HttpNotFound();
            }
            return View(localites);
        }

        // POST: Localites/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,cp,localite")] Localites localites)
        {
            if (ModelState.IsValid)
            {
                db.Entry(localites).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(localites);
        }

        // GET: Localites/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Localites localites = db.Localites.Find(id);
            if (localites == null)
            {
                return HttpNotFound();
            }
            return View(localites);
        }

        // POST: Localites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Localites localites = db.Localites.Find(id);
            db.Localites.Remove(localites);
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
