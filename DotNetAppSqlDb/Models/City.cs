using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusTickets.Models
{
    public class City
    {
        [Key]
        public int cityId { get; set; }

        public string cityName { get; set; }

        public string cityCode { get; set; }
    }
}