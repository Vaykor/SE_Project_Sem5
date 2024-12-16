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

        public string Name { get; set; }

        //Changed DateOnly to DateTime
        //If you wanna use DateOnly use it like this:
        //DateTime(DateOnly, TimeOnly)
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<TripSegment>? TripSegments { get; set; }



    }
}
