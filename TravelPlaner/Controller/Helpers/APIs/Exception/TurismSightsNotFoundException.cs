using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlaner.Controller.Helpers.APIs.Exception
{
    public  class TurismSightsNotFoundException : System.Exception
    {
        public TurismSightsNotFoundException() : base($"No turism sights found of givenn city!")
        {
        }
    }
}
