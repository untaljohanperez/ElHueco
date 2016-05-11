using ElHueco.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ElHueco.Controllers
{
    public class ComprasController : Controller
    {
        ElHuecoContext db = new ElHuecoContext();
        // GET: Compras
        public ActionResult Index()
        {
            return View(db.Compras.ToList());
        }

        // GET: Compras/Details/5
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var compra = db.Compras.Find(id);
            if (compra == null)
            {
                return HttpNotFound();
            }
            return View(compra);
        }

        // GET: Compras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Compras/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,proveedor,pathSoporte")] Compra compra)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Compras.Add(compra);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(compra);
            }
            catch
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }

        // GET: Compras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var compra = db.Compras.Find(id);
            if (compra == null)
            {
                return HttpNotFound();
            }

            return View(compra);
        }

        // POST: Compras/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id, proveedor, pathSoporte")] Compra compra)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(compra).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                       
                }
                return View(compra);
            }
            catch
            {
                return View(compra);
            } 
        }

        // GET: Compras/Delete/5
        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var compra = db.Compras.Find(id);
            if (compra == null)
            {
                return HttpNotFound();
            }
            return View(compra);
        }

        // POST: Compras/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            try
            {
                if (id  == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                var compra = db.Compras.Find(id);
                db.Compras.Remove(compra);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
