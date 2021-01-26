using BusTickets.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusTickets.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Age> user_ages { get; set; }
        public DbSet<City> user_cities { get; set; }
        public DbSet<Day> user_days { get; set; }
        public DbSet<Map> user_map { get; set; }
        public DbSet<Schedule> user_schedule { get; set; }
        public DbSet<Ticket> user_tickets { get; set; }
    }
}
