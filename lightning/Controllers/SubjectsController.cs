using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using lightning.Models;
using Microsoft.AspNet.Identity;

namespace lightning.Controllers
{
    [Authorize]
    public class SubjectsController : Controller
    {
        private SubjectTrackingDB db = new SubjectTrackingDB();
        private string _username;
       // private string redirectaction;

        // GET: Subjects
        public ActionResult Index()
        {
            return View(db.Subjects.ToList());
        }

        // GET: Subjects
        public ActionResult SubLook(string subjectarea)
        {
            _username = User.Identity.GetUserName();
            ViewBag.Area = subjectarea;
            return View(db.Subjects.Where(t => t.Title == subjectarea && t.UserName == _username).ToList());
        }

        // GET: Subjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subject subject = db.Subjects.Find(id);
            if (subject == null)
            {
                return HttpNotFound();
            }
            return View(subject);
        }

        // GET: Subjects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Subjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SubjectID,Title,Module,Description,complete1,complete2,complete3,complete4,complete5,complete6,tested1,tested2,tested3,tested4,tested5,tested6,CreatedDate,Username")] Subject subject)
        {
            
            if (ModelState.IsValid)
            {
                subject.ModifiedDate = DateTime.Today;
                db.Subjects.Add(subject);
                db.SaveChanges();
             //   redirectaction = "SubLook?subjectarea=" + subject.Title;
                return RedirectToAction("SubLook","Subjects", new { subjectarea = subject.Title });
            }

            return View(subject);
        }

        // GET: Subjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subject subject = db.Subjects.Find(id);
            if (subject == null)
            {
                return HttpNotFound();
            }
            return View(subject);
        }

        // POST: Subjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SubjectID,Title,Module,Description,complete1,complete2,complete3,complete4,complete5,complete6,tested1,tested2,tested3,tested4,tested5,tested6,CreatedDate,Username")] Subject subject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subject).State = EntityState.Modified;
                subject.CreatedDate = 
                subject.ModifiedDate = DateTime.Now;
                db.SaveChanges();
                //redirectaction = "SubLook?subjectarea=" + subject.Title;
                return RedirectToAction("SubLook","Subjects", new { subjectarea = subject.Title });
            }
            return View(subject);
        }

        // GET: Subjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subject subject = db.Subjects.Find(id);
            if (subject == null)
            {
                return HttpNotFound();
            }
            return View(subject);
        }

        // POST: Subjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Subject subject = db.Subjects.Find(id);
            db.Subjects.Remove(subject);
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
