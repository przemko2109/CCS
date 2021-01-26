using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusTickets.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public int ScheduleId { get; set; }

        public String UserName { get; set; }

        public int AgeId { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [NotMapped]
        public List<SelectListItem> Schedule { get; set; }

        [NotMapped]
        public List<SelectListItem> Age { get; set; }
    }
}
