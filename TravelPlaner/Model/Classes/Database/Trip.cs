using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlaner.Model.Classes.Database
{
    public class Trip
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public DateOnly StartDate { get; set; }

        public DateOnly EndDate { get; set; }

        public List<TripSegment>? TripSegments { get; set; }

    }
}
