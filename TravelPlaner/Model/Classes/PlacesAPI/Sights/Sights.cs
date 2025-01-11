using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlaner.Model.Classes.PlacesAPI.Sights
{
    public class Sights
    {
        public string? type { get; set; }
        public Properties? properties { get; set; }
        public Geometry? geometry { get; set; }
    }
}
