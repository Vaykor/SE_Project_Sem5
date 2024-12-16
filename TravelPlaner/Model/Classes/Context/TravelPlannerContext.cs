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
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Destination> Destination { get; set; }
        public DbSet<Landmark> Landmarks { get; set; }
        public DbSet<RestingPoint> RestingPoints { get; set; }
        public DbSet<TripMemory> TripMemory { get; set; }
        public DbSet<TripSegment> TripSegment { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=TravelPlannerDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

    }
}
