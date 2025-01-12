using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlaner.Controller.Helpers.APIs.Exception
{
    public  class TouristSightsNotFoundException : System.Exception
    {
        public TouristSightsNotFoundException() : base($"No turism sights found of givenn city!")
        {
        }
    }
}
