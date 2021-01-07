using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusTickets.Models
{
    public class Map
    {
        public Map(int route_id, string exit_city, string destination_city, int distance)
        {
            routeId = route_id;
            exitCity = exit_city;
            destinationCity = destination_city;
            Distance = distance;
        }

        public int routeId { get; set; }

        public string exitCity { get; set; }

        public string destinationCity { get; set; }

        public int Distance { get; set; }
    }
}