using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChaMPSMVC.Models;

namespace ChaMPSMVC.Controllers
{
    public class ScheduleListController : Controller
    {
        private ScheduleContext schcontext = new ScheduleContext();
        //
        // GET: /ScheduleList/
        //
        public ActionResult Index()
        {
            IEnumerable<Schedule> schCollection = schcontext.Schedules.Where(sch => sch.schPlant == 4).ToList<Schedule>();
            ViewBag.Message = "You have (" + schCollection.Count() + ") schedules.";
            return View(schCollection);
        }
        /// <summary>
        /// GET: /ScheduleList/Details?schid={schid}
        /// 
        /// The user has selected to view details about the selected schedule.
        /// </summary>
        /// <param name="schid"></param>
        /// <returns></returns>
        public ActionResult Details(int schid = 0)
        {
            Schedule schItem = schcontext.Schedules.Find(schid);
            if (schItem == null)
                return HttpNotFound();
            return View(schItem);
        }
        /// <summary>
        /// GET: /ScheduleList/Edit?schid={schid}
        /// 
        /// The user has selected to update the selected schedule.
        /// </summary>
        /// <param name="schid"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(int schid = 0)
        {
            Schedule schItem = schcontext.Schedules.Find(schid);
            if (schItem == null)
                return HttpNotFound();

            return View(schItem);
        }
        /// <summary>
        /// POST: /ScheduleList/Edit?schid={schid}
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(
           [Bind(Include = "schActive, schKey")]
         Schedule theSchRow)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Schedule schItem = schcontext.Schedules.Find(theSchRow.schKey);
                    if (schItem == null)
                        return HttpNotFound();
                    schItem.schActive = theSchRow.schActive;
                    schcontext.Entry(schItem).State = EntityState.Modified;
                    schcontext.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(theSchRow);
        }

    }
}
