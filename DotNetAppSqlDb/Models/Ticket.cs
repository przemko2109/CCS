using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusTickets.Models
{
    public class Ticket
    {
        public Ticket(int id, int route_id, int schedule_id, int user_id, string age)
        {
            Id = id;
            routeId = route_id;
            scheduleId = schedule_id;
            userId = user_id;
            Age = age;
        }

        public int Id { get; set; }

        public int scheduleId { get; set; }

        public int userId { get; set; }

        public int routeId { get; set; }

        public string Age { get; set; }
    }
}