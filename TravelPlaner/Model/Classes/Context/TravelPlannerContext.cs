using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlaner.Model.Classes.Database;

namespace TravelPlaner.Model.Classes.Context
{
    public class TravelPlannerContext : DbContext
    {
        public DbSet<Trip>? Trips { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Connection_String");
        }
        
    }
}
