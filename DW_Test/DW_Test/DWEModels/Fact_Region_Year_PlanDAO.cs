using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_Region_Year_PlanDAO
    {
        public long Id { get; set; }
        public long? RegionId { get; set; }
        public long? Year { get; set; }
        public decimal? RevenuePlan { get; set; }
    }
}
