﻿using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Fact_Customer_Quarter_PlanDAO
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public long QuarterKey { get; set; }
        public decimal? Revenue { get; set; }
    }
}
