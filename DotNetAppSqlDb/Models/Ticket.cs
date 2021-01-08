using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusTickets.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        public int scheduleId { get; set; }

        public int userId { get; set; }

        public int routeId { get; set; }

        public string Age { get; set; }
    }
}