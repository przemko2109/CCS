using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusTickets.Models
{
    public class City
    {
        public City(int city_id, string city_name, string city_code)
        {
            cityId = city_id;
            cityName = city_name;
            cityCode = city_code;
        }

        public int cityId { get; set; }

        public string cityName { get; set; }

        public string cityCode { get; set; }
    }
}