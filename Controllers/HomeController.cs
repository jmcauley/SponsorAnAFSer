﻿using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
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
        // POST: /Home/Create
        [HttpPost]
        public ActionResult CreateFromServiceId(StudentWidget studentwidget)
        {
            var widget = new StudentWidget();

            try{
                using (var svc = new WebserviceFundAFSerSoapClient())
                {
                    XElement studentAccount = svc.AFSWidgetGetProgramDetails("afserwidget", "globalwidgerasfer2012",
                                                                             studentwidget.ServiceId.ToString());


                    Guid serviceId;
                    DateTime endDate;

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
                        widget.EndDate = DateTime.TryParse(studentAccount.Descendants("Widget_End_Date").First().Value, out endDate) ? endDate : DateTime.Now.AddMonths(3);
                        widget.FundraisingAmount = decimal.Parse(studentAccount.Descendants("Widget_Amount").First().Value);

                        return View(widget);
                    }
                    //If we get here and didn't hit the View or an Error, then it is a bad Id.
                    
                }
            }
            catch(Exception e)
            {
                TempData["WSError"] = "Error in Global Link response: " + e.Message;
            }

            return RedirectToAction("Index");
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
                    var reply = svc.AFSWidgetSetCode("afserwidget", "globalwidgerasfer2012",
                                         studentwidget.ServiceId.ToString(),
                                         studentwidget.StudentWidgetId.ToString(),
                                         "http://donatew.afsusa.org/SponsorAnAFSer/Widget/Details/" + studentwidget.StudentWidgetId.ToString(),
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
        // POST: /Search
        [HttpPost]
        public ActionResult Search(FormCollection formCollection)
        {
            var search = formCollection["searchBox"];
            //Search by service id if it is a guid, otherwise search by last name
            var serviceId = Guid.Empty;
            if (Guid.TryParse(search, out serviceId))
            {
                var widget = _db.StudentWidgets.FirstOrDefault(w => w.ServiceId == serviceId);
                if (widget != null)
                {
                    var routeDict = new RouteValueDictionary {{"id", widget.StudentWidgetId}};
                    return RedirectToAction("Edit",routeDict);
                }
            }

            var widgets = _db.StudentWidgets.Where(w => w.LastName == search);

            return View(widgets);
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