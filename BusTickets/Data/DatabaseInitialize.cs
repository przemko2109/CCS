using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTickets.Data
{
    public static class DatabaseInitialize
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if(context.user_schedule.Any())
            {
                return;
            }

            if (context.user_tickets.Any())
            {
                return;
            }

            if (context.user_map.Any())
            {
                return;
            }
            
            if (context.user_days.Any())
            {
                return;
            }
            
            if (context.user_cities.Any())
            {
                return;
            }
            
            if (context.user_ages.Any())
            {
                return;
            }
            
            context.SaveChanges();
        }
    }
}
