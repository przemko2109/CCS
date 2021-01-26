using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusTickets.Models
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }

        public TimeSpan Hour { get; set; }

        public int MapId { get; set; }

        public int DayId { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [NotMapped]
        public List<SelectListItem> Map { get; set; }

        [NotMapped]
        public List<SelectListItem> Days { get; set; }
    }
}
