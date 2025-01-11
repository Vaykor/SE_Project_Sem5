using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlaner.Model.Classes.PlacesAPI.Autocomplete
{
    public class Timezone
    {
        public string name { get; set; }
        public string offset_STD { get; set; }
        public int offset_STD_seconds { get; set; }
        public string offset_DST { get; set; }
        public int offset_DST_seconds { get; set; }
        public string abbreviation_STD { get; set; }
        public string abbreviation_DST { get; set; }
    }
}
