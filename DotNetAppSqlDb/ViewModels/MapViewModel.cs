using BusTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusTickets.ViewModels
{
    public class MapViewModel
    {
        public MapViewModel(List<Map> map)
        {
            Map = map;
        }
        public List<Map> Map { get; set; }
    }
}