﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetailDto
    {
        public string Name { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string FuelType { get; set; }
        public decimal DailyPrice { get; set; }
    }
}