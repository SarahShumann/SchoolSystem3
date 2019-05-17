using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SchoolSystem3.Models;

namespace SchoolSystem3.Controllers
{
    public class MajorController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Major
        //[Authorize(Roles ="CanManagePage")]
        public ActionResult Index()
        {
            
            //if (User.IsInRole("CanManagePage"))
           // {
                var majors = db.Majors.Include(m => m.Teacher);
                return View(majors.ToList());
           // }
           // else
              //  return View("ReadOnlyIndex");

            
        }
        public ActionResult ReadOnlyIndex()
        {
            var majors1 = db.Majors.Include(m => m.Teacher);
            return View(majors1.ToList());
        }


        // GET: Major/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Major major = db.Majors.Find(id);
            if (major == null)
            {
                return HttpNotFound();
            }
            return View(major);
        }

        // GET: Major/Create
        public ActionResult Create()
        {
            ViewBag.TeacherID = new SelectList(db.Teachers, "TeacherID", "FirstName");
            return View();
        }

        // POST: Major/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MajorID,Name,TeacherID")] Major major)
        {
            if (ModelState.IsValid)
            {
                db.Majors.Add(major);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TeacherID = new SelectList(db.Teachers, "TeacherID", "FirstName", major.TeacherID);
            return View(major);
        }

        // GET: Major/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Major major = db.Majors.Find(id);
            if (major == null)
            {
                return HttpNotFound();
            }
            ViewBag.TeacherID = new SelectList(db.Teachers, "TeacherID", "FirstName", major.TeacherID);
            return View(major);
        }

        // POST: Major/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MajorID,Name,TeacherID")] Major major)
        {
            if (ModelState.IsValid)
            {
                db.Entry(major).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TeacherID = new SelectList(db.Teachers, "TeacherID", "FirstName", major.TeacherID);
            return View(major);
        }

        // GET: Major/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Major major = db.Majors.Find(id);
            if (major == null)
            {
                return HttpNotFound();
            }
            return View(major);
        }

        // POST: Major/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Major major = db.Majors.Find(id);
            db.Majors.Remove(major);
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
