using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusTickets.Models
{
    public class Map
    {
        [Key]
        public int Id { get; set; }

        public int ExitCityId { get; set; }

        public int DestinationCityId { get; set; }

        public int Distance { get; set; }

        [NotMapped]
        public List<SelectListItem> ExitCities { get; set; }

        [NotMapped]
        public List<SelectListItem> DestinationCities { get; set; }
    }
}
