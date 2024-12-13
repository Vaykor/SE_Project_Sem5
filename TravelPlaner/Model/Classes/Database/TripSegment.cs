using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlaner.Model.Classes.Database
{
    public class TripSegment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<TripMemory> Memories { get; set; }

        public List<Expense> Expenses { get; set; }

        public List<Destination> Destinations  { get; set; }

        
    }
}
