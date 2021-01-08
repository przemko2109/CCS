using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusTickets.Models
{
    public class Schedule
    {
        [Key]
        public int scheduleId { get; set; }

        public TimeSpan Hour { get; set; }

        public string City { get; set; }

        public string Day { get; set; }
    }
}