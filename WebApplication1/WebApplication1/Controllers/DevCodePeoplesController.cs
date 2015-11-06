using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DevCodePeoplesController : Controller
    {
        private Database42Entities db = new Database42Entities();

        // GET: DevCodePeoples
        public ActionResult Index()
        {
            return View(db.DevCodePeoples.ToList());
        }

        // GET: DevCodePeoples/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DevCodePeople devCodePeople = db.DevCodePeoples.Find(id);
            if (devCodePeople == null)
            {
                return HttpNotFound();
            }
            return View(devCodePeople);
        }

        // GET: DevCodePeoples/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DevCodePeoples/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "firstName,lastName,codeName,person_id")] DevCodePeople devCodePeople)
        {
            if (ModelState.IsValid)
            {
                db.DevCodePeoples.Add(devCodePeople);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(devCodePeople);
        }

        // GET: DevCodePeoples/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DevCodePeople devCodePeople = db.DevCodePeoples.Find(id);
            if (devCodePeople == null)
            {
                return HttpNotFound();
            }
            return View(devCodePeople);
        }

        // POST: DevCodePeoples/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "firstName,lastName,codeName,person_id")] DevCodePeople devCodePeople)
        {
            if (ModelState.IsValid)
            {
                db.Entry(devCodePeople).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(devCodePeople);
        }

        // GET: DevCodePeoples/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DevCodePeople devCodePeople = db.DevCodePeoples.Find(id);
            if (devCodePeople == null)
            {
                return HttpNotFound();
            }
            return View(devCodePeople);
        }

        // POST: DevCodePeoples/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DevCodePeople devCodePeople = db.DevCodePeoples.Find(id);
            db.DevCodePeoples.Remove(devCodePeople);
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
