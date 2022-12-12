using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Fact_RD_SaleChannelQuarterPlanDAO
    {
        public long Id { get; set; }
        public long? SaleChannelId { get; set; }
        public long? QuarterKey { get; set; }
        public decimal? RevenuePlan { get; set; }
    }
}
