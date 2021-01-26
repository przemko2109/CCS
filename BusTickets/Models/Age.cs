using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusTickets.Models
{
    public class Age
    {
        [Key]
        public int AgeId { get; set; }

        public string AgeName { get; set; }

        public decimal Percentage { get; set; }
    }
}
