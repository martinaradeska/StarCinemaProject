using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CinemaStar.Models;

namespace CinemaStar.Controllers
{
    public class ShowTimeAndDatesController : Controller
    {
        private Movie_Booking_DataContext db = new Movie_Booking_DataContext();

        // GET: ShowTimeAndDates
        public ActionResult Index()
        {
            return View(db.ShowTimeAndDate.ToList());
        }

        // GET: ShowTimeAndDates/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShowTimeAndDate showTimeAndDate = db.ShowTimeAndDate.Find(id);
            if (showTimeAndDate == null)
            {
                return HttpNotFound();
            }
            return View(showTimeAndDate);
        }

        // GET: ShowTimeAndDates/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShowTimeAndDates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ShowDate,StartTime,Duration")] ShowTimeAndDate showTimeAndDate)
        {
            if (ModelState.IsValid)
            {
                db.ShowTimeAndDate.Add(showTimeAndDate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(showTimeAndDate);
        }


        // GET: ShowTimeAndDates/Edit/5
        [Authorize(Roles = "Admin")]

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShowTimeAndDate showTimeAndDate = db.ShowTimeAndDate.Find(id);
            if (showTimeAndDate == null)
            {
                return HttpNotFound();
            }
            return View(showTimeAndDate);
        }

        // POST: ShowTimeAndDates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ShowDate,StartTime,Duration")] ShowTimeAndDate showTimeAndDate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(showTimeAndDate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(showTimeAndDate);
        }

        // GET: ShowTimeAndDates/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShowTimeAndDate showTimeAndDate = db.ShowTimeAndDate.Find(id);
            if (showTimeAndDate == null)
            {
                return HttpNotFound();
            }
            return View(showTimeAndDate);
        }
        [Authorize(Roles = "Admin")]
        // POST: ShowTimeAndDates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShowTimeAndDate showTimeAndDate = db.ShowTimeAndDate.Find(id);
            db.ShowTimeAndDate.Remove(showTimeAndDate);
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
