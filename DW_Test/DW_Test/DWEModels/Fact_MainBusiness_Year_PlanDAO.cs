using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_MainBusiness_Year_PlanDAO
    {
        public long Id { get; set; }
        public long? MainBusinessId { get; set; }
        public long? Year { get; set; }
        public decimal? RevenuePlan { get; set; }
        public decimal? QuantityPlan { get; set; }
    }
}
