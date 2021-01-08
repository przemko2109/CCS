using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BusTickets.Models
{
    public class MyDatabaseContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MyDatabaseContext() : base("name=DatabaseConnection")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.SetInitializer<demoEntities>(null);
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);


        }
        public System.Data.Entity.DbSet<BusTickets.Models.User> Users { get; set; }
        public System.Data.Entity.DbSet<BusTickets.Models.Ticket> Tickets { get; set; }
        public System.Data.Entity.DbSet<BusTickets.Models.Schedule> Schedule { get; set; }
        public System.Data.Entity.DbSet<BusTickets.Models.Map> Map { get; set; }
    }
}
