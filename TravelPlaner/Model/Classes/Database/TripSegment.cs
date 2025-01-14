using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlaner.Model.Classes.Database
{
    public class TripSegment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // Navigation Properties for Related Entities
        public List<TripMemory> Memories { get; set; } = new List<TripMemory>();
        public List<Expense> Expenses { get; set; } = new List<Expense>();
        public List<Destination> Destinations { get; set; } = new List<Destination>();

        // Foreign Key and Navigation Property for Trip
        public int TripId { get; set; }
        public Trip Trip { get; set; }
    }
}
