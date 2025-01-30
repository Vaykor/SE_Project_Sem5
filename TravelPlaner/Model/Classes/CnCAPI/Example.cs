using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlaner.Model.Classes.CnCAPI
{
    public class Example
    {
        public bool error { get; set; }
        public string msg { get; set; }
        public IList<Datum> data { get; set; }
    }
}
