﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlaner.Model.Classes.Database
{
    public class Landmark : Destination
    {
        public string Name { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }


    }
}
