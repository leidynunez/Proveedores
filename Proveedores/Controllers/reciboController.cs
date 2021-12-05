using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proveedores.Dal;
using Proveedores.Models;

namespace Proveedores.Controllers
{
    public class reciboController : Controller
    {
        private ReciboContext db = new ReciboContext();

        // GET: recibo
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        // GET: recibo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recibos recibos = db.Students.Find(id);
            if (recibos == null)
            {
                return HttpNotFound();
            }
            return View(recibos);
        }

        // GET: recibo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: recibo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Proveedor,Monto,Moneda,Fecha,Comentario")] recibos recibos)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(recibos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(recibos);
        }

        // GET: recibo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recibos recibos = db.Students.Find(id);
            if (recibos == null)
            {
                return HttpNotFound();
            }
            return View(recibos);
        }

        // POST: recibo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Proveedor,Monto,Moneda,Fecha,Comentario")] recibos recibos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recibos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recibos);
        }

        // GET: recibo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recibos recibos = db.Students.Find(id);
            if (recibos == null)
            {
                return HttpNotFound();
            }
            return View(recibos);
        }

        // POST: recibo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            recibos recibos = db.Students.Find(id);
            db.Students.Remove(recibos);
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
