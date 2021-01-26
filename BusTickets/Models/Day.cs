using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusTickets.Models
{
    public class Day
    {
        [Key]
        public int DayId { get; set; }

        public string DayName { get; set; }
    }
}
