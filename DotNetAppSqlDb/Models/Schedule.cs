using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusTickets.Models
{
    public class Schedule
    {
        public Schedule(int schedule_id, TimeSpan hour, string city, string day)
        {
            scheduleId = schedule_id;
            City = city;
            Hour = hour;
            Day = day;
        }

        public int scheduleId { get; set; }

        public TimeSpan Hour { get; set; }

        public string City { get; set; }

        public string Day { get; set; }
    }
}