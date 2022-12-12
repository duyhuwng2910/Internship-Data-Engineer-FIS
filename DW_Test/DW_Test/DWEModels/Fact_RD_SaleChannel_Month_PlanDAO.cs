using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_RD_SaleChannel_Month_PlanDAO
    {
        public long Id { get; set; }
        public long? SaleChannelId { get; set; }
        public long? MonthKey { get; set; }
        public decimal? RevenuePlan { get; set; }
    }
}
