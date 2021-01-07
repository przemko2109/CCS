using BusTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusTickets.ViewModels
{
    public class ScheduleViewModel
    {
        public ScheduleViewModel(List<Schedule> schedule)
        {
            Schedule = schedule;
        }
        public List<Schedule> Schedule { get; set; }
    }
}