using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlaner.Model.Classes.PlacesAPI.Sights
{
    public class Historic
    {
        public string? type { get; set; }
        public string? castle_type { get; set; }
        public string? importance { get; set; }
        public string? civilization { get; set; }
        public string? period { get; set; }
        public object? start_date { get; set; }
    }
}
