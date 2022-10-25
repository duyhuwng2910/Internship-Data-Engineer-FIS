using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Fact_SaleChannel_Quarter_PlanDAO
    {
        public long Id { get; set; }
        public long SaleChannelId { get; set; }
        public long QuarterKey { get; set; }
        public decimal? Revenue { get; set; }
    }
}
