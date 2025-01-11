using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlaner.Model.Classes.PlacesAPI.Sights
{
    public class Properties
    {
        public string? name { get; set; }
        public string? country { get; set; }
        public string? country_code { get; set; }
        public string? state { get; set; }
        public string? county { get; set; }
        public string? city { get; set; }
        public string? postcode { get; set; }
        public string? suburb { get; set; }
        public string? quarter { get; set; }
        public string? street { get; set; }
        public string? housenumber { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }
        public string? state_code { get; set; }
        public string? formatted { get; set; }
        public string? address_line1 { get; set; }
        public string? address_line2 { get; set; }
        public IList<string>? categories { get; set; }
        public IList<string>? details { get; set; }
        public DatasourceSight? datasource { get; set; }
        public string? website { get; set; }
        public string? opening_hours { get; set; }
        public NameInternational? name_international { get; set; }
        public Contact? contact { get; set; }
        public WikiAndMedia? wiki_and_media { get; set; }
        public Historic? historic { get; set; }
        public string? place_id { get; set; }
        public Facilities? facilities { get; set; }
        public Building? building { get; set; }
        public PlaceOfWorship? place_of_worship { get; set; }
        public string? old_name { get; set; }
        public string? description { get; set; }
        public NameOther? name_other { get; set; }
        public Restrictions? restrictions { get; set; }
    }
}
