using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlaner.Model.Enums;

namespace TravelPlaner.Model.Classes.Database
{
    public class RestingPoint
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public RestingPointType Type { get; set; } //Added as enum but not sure if database can store such type. Always can change to string using function nameof() 
        public int LengthOfStay { get; set; }
        public string ContactInfo { get; set; } // Email or phone number

    }
}
