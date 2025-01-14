using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlaner.Model.Classes.PlacesAPI.Autocomplete
{
    public class Rank
    {
        public double importance { get; set; }
        public double confidence { get; set; }
        public double confidence_city_level { get; set; }
        public string? match_type { get; set; }
    }
}
