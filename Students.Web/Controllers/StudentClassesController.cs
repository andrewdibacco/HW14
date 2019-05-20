using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CollegeDBEF.DAL;
using CollegeDBEF.Models;

namespace Students.Web.Controllers
{
    public class StudentClassesController : Controller
    {
        private CollegeContext db = new CollegeContext();

        // GET: StudentClasses
        public ActionResult Index()
        {
            var studentClasses = db.StudentClasses.Include(s => s.Classes).Include(s => s.Students);
            return View(studentClasses.ToList());
        }

        // GET: StudentClasses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentClasses studentClasses = db.StudentClasses.Find(id);
            if (studentClasses == null)
            {
                return HttpNotFound();
            }
            return View(studentClasses);
        }

        // GET: StudentClasses/Create
        public ActionResult Create()
        {
            ViewBag.ClassesID = new SelectList(db.Classes, "ID", "Title");
            ViewBag.StudentsID = new SelectList(db.Students, "ID", "FName");
            return View();
        }

        // POST: StudentClasses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ClassesID,StudentsID")] StudentClasses studentClasses)
        {
            if (ModelState.IsValid)
            {
                db.StudentClasses.Add(studentClasses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClassesID = new SelectList(db.Classes, "ID", "Title", studentClasses.ClassesID);
            ViewBag.StudentsID = new SelectList(db.Students, "ID", "FName", studentClasses.StudentsID);
            return View(studentClasses);
        }

        // GET: StudentClasses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentClasses studentClasses = db.StudentClasses.Find(id);
            if (studentClasses == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClassesID = new SelectList(db.Classes, "ID", "Title", studentClasses.ClassesID);
            ViewBag.StudentsID = new SelectList(db.Students, "ID", "FName", studentClasses.StudentsID);
            return View(studentClasses);
        }

        // POST: StudentClasses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ClassesID,StudentsID")] StudentClasses studentClasses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentClasses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClassesID = new SelectList(db.Classes, "ID", "Title", studentClasses.ClassesID);
            ViewBag.StudentsID = new SelectList(db.Students, "ID", "FName", studentClasses.StudentsID);
            return View(studentClasses);
        }

        // GET: StudentClasses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentClasses studentClasses = db.StudentClasses.Find(id);
            if (studentClasses == null)
            {
                return HttpNotFound();
            }
            return View(studentClasses);
        }

        // POST: StudentClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentClasses studentClasses = db.StudentClasses.Find(id);
            db.StudentClasses.Remove(studentClasses);
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
