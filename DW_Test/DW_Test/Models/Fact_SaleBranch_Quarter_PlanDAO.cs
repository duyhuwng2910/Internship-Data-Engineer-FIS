﻿using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Fact_SaleBranch_Quarter_PlanDAO
    {
        public long Id { get; set; }
        public long SaleBranchId { get; set; }
        public long QuarterKey { get; set; }
        public decimal? Revenue { get; set; }
    }
}
