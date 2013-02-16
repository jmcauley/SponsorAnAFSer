using System;
using System.Data;
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
                    widget.Srn = studentAccount.Descendants("Service_Ref").First().Value;
                    widget.AreaTeam = studentAccount.Descendants("Area_Team_Name").First().Value;
                    widget.State = studentAccount.Descendants("State").First().Value;
                    widget.EnabledStatus = 1;
                    widget.DisplayName = widget.FirstName + ' ' + widget.LastName;

                    //This should be given to us by AFS
                    widget.EndDate = DateTime.Now.AddMonths(3).Date;
                    widget.FundraisingAmount = 3000;

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
                using (var svc = new WebserviceFundAFSerSoapClient())
                {
                    var reply = svc.AFSWidgetSetCode("afserwidget2012", "white1Hallfl2oreappleCity",
                                         studentwidget.ServiceId.ToString(),
                                         studentwidget.StudentWidgetId.ToString(),
                                         studentwidget.StudentWidgetId.ToString(),
                                         studentwidget.EndDate.ToString());
                }
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
            var widget = new StudentWidget();
            try
            {
                if (ModelState.IsValid)
                {
                    widget = _db.StudentWidgets.Find(studentwidget.StudentWidgetId);
                    widget.FundraisingAmount = studentwidget.FundraisingAmount;
                    widget.EndDate = studentwidget.EndDate;
                    widget.BlogUrl = studentwidget.BlogUrl;
                    widget.DestinationCountry = studentwidget.DestinationCountry;
                    widget.EnabledStatus = studentwidget.EnabledStatus;
                    widget.DisplayName = studentwidget.DisplayName;

                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException e)
            {
                Console.WriteLine(e);
                //Log the error (add a variable name after DataException)
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
                return View(widget);
            }
            return RedirectToAction("Index");
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