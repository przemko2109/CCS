using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusTickets.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        public string CityName { get; set; }
    }
}
