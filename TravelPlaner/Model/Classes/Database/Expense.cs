﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlaner.Model.Classes.Database
{
    public class Expense
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }

        public int TripSegmentId { get; set; }
        public TripSegment TripSegment { get; set; }

    }
}
