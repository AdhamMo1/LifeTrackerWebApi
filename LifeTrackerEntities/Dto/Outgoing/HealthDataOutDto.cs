﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeTrackerEntities.Dto.Outgoing
{
    public class HealthDataOutDto
    {
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public string? BloodType { get; set; }
        public string? Race { get; set; }
        public bool? UseGlasses { get; set; }
    }
}
