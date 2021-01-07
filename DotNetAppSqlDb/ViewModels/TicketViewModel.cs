using BusTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusTickets.ViewModels
{
    public class TicketViewModel
    {
        public TicketViewModel(List<Ticket> tickets)
        {
            Tickets = tickets;
        }
        public List<Ticket> Tickets { get; set; }
    }
}