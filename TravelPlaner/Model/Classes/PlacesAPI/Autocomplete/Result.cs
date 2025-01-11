using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlaner.Model.Classes.PlacesAPI.Autocomplete
{
    public class Result
    {
        public Datasource? datasource { get; set; }
        public string? country { get; set; }
        public string? country_code { get; set; }
        public string? state { get; set; }
        public string? county { get; set; }
        public string? city { get; set; }
        public double? lon { get; set; }
        public double? lat { get; set; }
        public string? result_type { get; set; }
        public string? formatted { get; set; }
        public string? address_line1 { get; set; }
        public string? address_line2 { get; set; }
        public string? category { get; set; }
        public Timezone? timezone { get; set; }
        public string? plus_code { get; set; }
        public string? plus_code_short { get; set; }
        public Rank? rank { get; set; }
        public string? place_id { get; set; }
    }
}
