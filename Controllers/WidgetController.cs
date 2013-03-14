using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SponsorAnAFSer.Models;

namespace SponsorAnAFSer.Controllers
{
    public class WidgetController : Controller
    {
        private readonly AdminContext _db = new AdminContext();
        //
        // GET: /Widget/

        public ActionResult Index()
        {
            return View();
        }

        // GET: /Home/Details/5

        public ActionResult Details(Guid id = default(Guid))
        {
            StudentWidget studentwidget = _db.StudentWidgets.Find(id);
            if (studentwidget == null)
            {
                return HttpNotFound();
            }
            ViewBag.Donations = studentwidget.AmountRaised;
            ViewBag.Percentage = (decimal)(studentwidget.AmountRaised / studentwidget.FundraisingAmount);
            return View(studentwidget);
        }
    }
}
