using System;
using System.Linq;
using System.Web.Mvc;
using System.Xml.Linq;
using SponsorAnAFSer.Models;
using SponsorAnAFSer.GlobalLinkWS;

namespace SponsorAnAFSer.Controllers
{
    public class HomeController : Controller
    {
        private readonly AdminContext _db = new AdminContext();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            var widgets = _db.StudentWidgets;
            var enabledWidgets = from w in widgets
                                 select w;

            ViewBag.WSError = TempData["WSError"];
            return View(enabledWidgets.ToList());
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(Guid id = default(Guid))
        {
            StudentWidget studentwidget = _db.StudentWidgets.Find(id);
            if (studentwidget == null)
            {
                return HttpNotFound();
            }
            return View(studentwidget);
        }

        //
        // POST: /Home/Create
        [HttpPost]
        public ActionResult CreateFromServiceId(StudentWidget studentwidget)
        {
            var widget = new StudentWidget();

            using (var svc = new WebserviceFundAFSerSoapClient())
            {
                XElement studentAccount = svc.AFSWidgetGetProgramDetails("afserwidget2012", "white1Hallfl2oreappleCity",
                                                                         studentwidget.ServiceId.ToString());


                Guid serviceId;

                if (studentAccount.Descendants("GLMessage").First().Value.Equals("Success"))
                {
                    bool isValidAcct = Guid.TryParse(studentAccount.Descendants("Service_ID").First().Value, out serviceId);
                    if (!isValidAcct)
                    {
                        TempData["WSError"] = "Not a valid Service Id.";
                        return RedirectToAction("Index");
                    }
                    widget.ServiceId = Guid.Parse(studentAccount.Descendants("Service_ID").First().Value);
                    widget.FirstName = studentAccount.Descendants("First_Name").First().Value;
                    widget.LastName = studentAccount.Descendants("Last_Name").First().Value;
                    widget.State = studentAccount.Descendants("State").First().Value;
                    widget.ProgramRefCode = studentAccount.Descendants("Program_Code").First().Value;
                    widget.DestinationCountry = studentAccount.Descendants("Hosting_Country").First().Value;

                    return View(widget);
                }
                TempData["WSError"] = "Not a valid Service Id.";
                return RedirectToAction("Index");
            }
            
        }


        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(StudentWidget studentwidget)
        {
            if (ModelState.IsValid)
            {
                studentwidget.StudentWidgetId = Guid.NewGuid();
                _db.StudentWidgets.Add(studentwidget);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(Guid id = default(Guid))
        {
            StudentWidget studentwidget = _db.StudentWidgets.Find(id);
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
            
            return View(studentwidget);
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(Guid id = default(Guid))
        {
            StudentWidget studentwidget = _db.StudentWidgets.Find(id);
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
            StudentWidget studentwidget = _db.StudentWidgets.Find(id);
            _db.StudentWidgets.Remove(studentwidget);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}