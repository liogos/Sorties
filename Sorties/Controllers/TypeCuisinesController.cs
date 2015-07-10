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
    public class TypeCuisinesController : Controller
    {
        private BddContextSorties db = new BddContextSorties();

        // GET: TypeCuisines
        public ActionResult Index()
        {
            return View(db.TypeCuisine.ToList());
        }

        // GET: TypeCuisines/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeCuisine typeCuisine = db.TypeCuisine.Find(id);
            if (typeCuisine == null)
            {
                return HttpNotFound();
            }
            return View(typeCuisine);
        }

        // GET: TypeCuisines/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeCuisines/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,type")] TypeCuisine typeCuisine)
        {
            if (ModelState.IsValid)
            {
                db.TypeCuisine.Add(typeCuisine);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(typeCuisine);
        }

        // GET: TypeCuisines/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeCuisine typeCuisine = db.TypeCuisine.Find(id);
            if (typeCuisine == null)
            {
                return HttpNotFound();
            }
            return View(typeCuisine);
        }

        // POST: TypeCuisines/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,type")] TypeCuisine typeCuisine)
        {
            if (ModelState.IsValid)
            {
                db.Entry(typeCuisine).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(typeCuisine);
        }

        // GET: TypeCuisines/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeCuisine typeCuisine = db.TypeCuisine.Find(id);
            if (typeCuisine == null)
            {
                return HttpNotFound();
            }
            return View(typeCuisine);
        }

        // POST: TypeCuisines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TypeCuisine typeCuisine = db.TypeCuisine.Find(id);
            db.TypeCuisine.Remove(typeCuisine);
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
