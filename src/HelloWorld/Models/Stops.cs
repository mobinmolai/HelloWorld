﻿using System;
using System.Collections.Generic;

namespace HelloWorld.Models
{
    public partial class Stops
    {
        public int Id { get; set; }
        public int? TripId { get; set; }
        public string Name { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? Order { get; set; }
        public DateTime? Arrival { get; set; }

        public virtual Trips Trip { get; set; }
    }
}
