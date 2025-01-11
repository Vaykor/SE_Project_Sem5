using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlaner.Model.Classes.PlacesAPI.Sights
{
    public class SightsResponse
    {
        public string? type { get; set; }
        public IList<Sights>? sights { get; set; }
    }
}
