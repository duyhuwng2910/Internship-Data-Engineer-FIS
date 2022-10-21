using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Fact_Sale_Channel_Quarter_PlanDAO
    {
        public long Id { get; set; }
        public long SaleChannelId { get; set; }
        public long QuarterKey { get; set; }
        public long? Quantity { get; set; }
        public long? UnitPrice { get; set; }
        public decimal? Revenue { get; set; }
    }
}
