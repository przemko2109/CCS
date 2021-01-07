using BusTickets.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusTickets.Controllers
{
    public class HomeController : Controller
    {
        private MyDatabaseContext db = new MyDatabaseContext();

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Index()
        {
            Trace.WriteLine("GET /Home/Index");
            return View();
        }

        public ActionResult About()
        {
            Trace.WriteLine("GET /Home/About");

            return View();
        }

        public ActionResult Contact()
        {
            Trace.WriteLine("GET /Home/Contact");

            return View();
        }

        public ActionResult ShowTickets()
        {
            Trace.WriteLine("GET /Home/DisplayTickets");
            return View(db.Tickets.ToList());
        }

        public ActionResult ShowMap()
        {
            Trace.WriteLine("GET /Home/DisplayMap");
            return View(db.Map.ToList());
        }

        public ActionResult ShowSchedule()
        {
            Trace.WriteLine("GET /Home/DisplaySchedule");
            return View(db.Schedule.ToList());
        }

        public ActionResult BuyTheTicket([Bind(Include = "routeId,scheduleId,userId,Age")] Ticket ticket)
        {
            Trace.WriteLine("POST /Home/BuyTheTicket");
            if (ModelState.IsValid)
            {
                db.Tickets.Add(ticket);
                db.SaveChanges();
                return RedirectToAction("ManageMap");
            }

            return View(ticket);
        }

    }
}