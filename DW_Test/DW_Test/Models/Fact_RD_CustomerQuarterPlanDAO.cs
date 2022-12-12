using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Fact_RD_CustomerQuarterPlanDAO
    {
        public long Id { get; set; }
        public long? CustomerId { get; set; }
        public long? QuarterKey { get; set; }
        public decimal? RevenuePlan { get; set; }
    }
}
