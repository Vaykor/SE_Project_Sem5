using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlaner.Model.Classes.CnCAPI
{
    public class Datum
    {
        public string iso2 { get; set; }
        public string iso3 { get; set; }
        public string country { get; set; }
        public IList<string> cities { get; set; }
    }
}
