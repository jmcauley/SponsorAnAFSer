using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SponsorAnAFSer.Models;

namespace SponsorAnAFSer.Controllers
{
    public class HomeController : Controller
    {
        private readonly AdminContext db = new AdminContext();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            var widgets = db.StudentWidgets;
            var enabledWidgets = from w in widgets
                                 select w;

            return View(enabledWidgets.ToList());
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(Guid id = default(Guid))
        {
            StudentWidget studentwidget = db.StudentWidgets.Find(id);
            if (studentwidget == null)
            {
                return HttpNotFound();
            }
            return View(studentwidget);
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(StudentWidget studentwidget)
        {
            if (ModelState.IsValid)
            {
                studentwidget.StudentWidgetId = Guid.NewGuid();
                db.StudentWidgets.Add(studentwidget);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentwidget);
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(Guid id = default(Guid))
        {
            StudentWidget studentwidget = db.StudentWidgets.Find(id);
            if (studentwidget == null)
            {
                return HttpNotFound();
            }
            return View(studentwidget);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        public ActionResult Edit(StudentWidget studentwidget)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentwidget).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentwidget);
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(Guid id = default(Guid))
        {
            StudentWidget studentwidget = db.StudentWidgets.Find(id);
            if (studentwidget == null)
            {
                return HttpNotFound();
            }
            return View(studentwidget);
        }

        //
        // POST: /Home/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Guid id)
        {
            StudentWidget studentwidget = db.StudentWidgets.Find(id);
            db.StudentWidgets.Remove(studentwidget);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}