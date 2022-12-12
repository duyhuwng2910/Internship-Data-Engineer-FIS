using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Fact_RD_RegionMonthPlanDAO
    {
        public long Id { get; set; }
        public long? RegionId { get; set; }
        public long? MonthKey { get; set; }
        public decimal? RevenuePlan { get; set; }
    }
}
