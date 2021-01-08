using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusTickets.Models
{
    public class Map
    {
        [Key]
        public int routeId { get; set; }

        public string exitCity { get; set; }

        public string destinationCity { get; set; }

        public int Distance { get; set; }
    }
}