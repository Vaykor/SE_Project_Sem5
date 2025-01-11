using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlaner.Model.Classes.PlacesAPI.Sights
{
    public class DatasourceSight
    {
        public string? sourcename { get; set; }
        public string? attribution { get; set; }
        public string? license { get; set; }
        public string? url { get; set; }
        public Raw raw { get; set; }
    }
}
