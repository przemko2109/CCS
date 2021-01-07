using BusTickets.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BusTickets.Controllers
{
    public class ManageController : Controller
    {
        private MyDatabaseContext db = new MyDatabaseContext();

        public ActionResult ManageMap()
        {
            Trace.WriteLine("GET /Manage/ManageMap");
            return View(db.Map.ToList());
        }

        public ActionResult ManageSchedule()
        {
            Trace.WriteLine("GET /Manage/ManageSchedule");
            return View(db.Schedule.ToList());
        }

        public ActionResult AddMap()
        {
            Trace.WriteLine("GET /Manage/AddMap");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddMap([Bind(Include = "exitCity,destinationCity,Distance")] Map map)
        {
            Trace.WriteLine("POST /Manage/AddMap");
            if (ModelState.IsValid)
            {
                db.Map.Add(map);
                db.SaveChanges();
                return RedirectToAction("ManageMap");
            }

            return View(map);
        }

        public ActionResult AddSchedule()
        {
            Trace.WriteLine("GET /Manage/AddSchedule");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddSchedule([Bind(Include = "Hour,City,Day")] Schedule schedule)
        {
            Trace.WriteLine("POST /Todos/Create");
            if (ModelState.IsValid)
            {
                db.Schedule.Add(schedule);
                db.SaveChanges();
                return RedirectToAction("ManageSchedule");
            }

            return View(schedule);
        }

        public ActionResult EditMap(int? id)
        {
            Trace.WriteLine("GET /Manage/EditMap/" + id);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Map map = db.Map.Find(id);
            if (map == null)
            {
                return HttpNotFound();
            }
            return View(map);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditMap([Bind(Include = "routeId,exitCity,destinationCity,Distance")] Map map)
        {
            Trace.WriteLine("POST /Manage/EditMap/" + map.routeId);
            if (ModelState.IsValid)
            {
                db.Entry(map).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ManageMap");
            }
            return View(map);
        }

        public ActionResult EditSchedule(int? id)
        {
            Trace.WriteLine("GET /Manage/EditSchedule/" + id);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Schedule schedule = db.Schedule.Find(id);
            if (schedule == null)
            {
                return HttpNotFound();
            }
            return View(schedule);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditSchedule([Bind(Include = "scheduleId,Hour,City,Day")] Schedule schedule)
        {
            Trace.WriteLine("POST /Manage/EditSchedule/" + schedule.scheduleId);
            if (ModelState.IsValid)
            {
                db.Entry(schedule).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ManageMap");
            }
            return View(schedule);
        }

        public ActionResult DeleteMap(int? id)
        {
            Trace.WriteLine("GET /Manage/DeleteMap/" + id);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Map todo = db.Map.Find(id);
            if (todo == null)
            {
                return HttpNotFound();
            }
            return View(todo);
        }

        [HttpPost, ActionName("DeleteMap")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteMapConfirmed(int id)
        {
            Trace.WriteLine("POST /Manage/DeleteMap/" + id);
            Map map = db.Map.Find(id);
            db.Map.Remove(map);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSchedule(int? id)
        {
            Trace.WriteLine("GET /Manage/DeleteSchedule/" + id);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Schedule todo = db.Schedule.Find(id);
            if (todo == null)
            {
                return HttpNotFound();
            }
            return View(todo);
        }

        [HttpPost, ActionName("DeleteSchedule")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteScheduleConfirmed(int id)
        {
            Trace.WriteLine("POST /Manage/DeleteSchedule/" + id);
            Schedule schedule = db.Schedule.Find(id);
            db.Schedule.Remove(schedule);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}