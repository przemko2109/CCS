using BusTickets.Data;
using BusTickets.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Principal;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BusTickets.Areas.Identity.Pages.Account.LoginModel;
using System.Security.Claims;

namespace BusTickets.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public UserController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult BuyTicket()
        {
            var userName = _userManager.GetUserId(HttpContext.User);

            var scheduleList = (from product in _context.user_schedule
                                select new SelectListItem()
                                {
                                    Text = product.Id.ToString(),
                                    Value = product.Id.ToString(),
                                }).ToList();

            scheduleList.Insert(0, new SelectListItem()
            {
                Text = "----Select----",
                Value = string.Empty
            });

            var ageList = (from product in _context.user_ages
                                select new SelectListItem()
                                {
                                    Text = product.AgeId.ToString(),
                                    Value = product.AgeId.ToString(),
                                }).ToList();

            ageList.Insert(0, new SelectListItem()
            {
                Text = "----Select----",
                Value = string.Empty
            });

            Ticket ticket = new Ticket();
            ticket.Age = ageList;
            ticket.Schedule = scheduleList;
            ticket.UserName = userName;
            return View(ticket);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BuyTicket([Bind("Id,ScheduleId,UserName,AgeId,Price,SchedulePrice,Percentage")] Ticket ticket)
        {
            var userName = _userManager.GetUserId(HttpContext.User);

            var percentage = _context.user_ages.ToList().FirstOrDefault(x => x.AgeId == ticket.AgeId).Percentage;
            var schedulePrice = _context.user_schedule.ToList().FirstOrDefault(x => x.Id == ticket.ScheduleId).Price;


            ticket.UserName = userName;
            ticket.Price = percentage * schedulePrice;

            if (ModelState.IsValid)
            {
                _context.user_tickets.Add(ticket);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ticket);
        }

        public IActionResult DeleteTicket(int? id)
        {
            Ticket ticket = _context.user_tickets.Find(id);
            return View(ticket);
        }
        [HttpPost, ActionName("DeleteTicket")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteTicket(int id)
        {
            Ticket ticket = _context.user_tickets.Find(id);
            _context.user_tickets.Remove(ticket);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        /*
        public IActionResult EditTicket(int? id)
        {
            Ticket ticket = _context.user_tickets.Find(id);
            return View(ticket);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditTicket([Bind("Id,ScheduleId,UserId,AgeId")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(ticket).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ticket);
        }
        */
        public IActionResult ShowAge()
        {
            return View(_context.user_ages.ToList());
        }

        public IActionResult ShowCities()
        {
            return View(_context.user_cities.ToList());
        }

        public IActionResult ShowMap()
        {
            return View(_context.user_map.ToList());
        }

        public IActionResult ShowSchedule()
        {
            return View(_context.user_schedule.ToList());
        }

        public IActionResult ShowTicket()
        {
            var userName = _userManager.GetUserId(HttpContext.User);
            IEnumerable<Ticket> tickets = _context.user_tickets.ToList().Where(x => x.UserName == userName);

            return View(tickets);
        }

        public IActionResult Index()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
