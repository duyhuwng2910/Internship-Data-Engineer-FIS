using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_Item_Month_PlanDAO
    {
        public long Id { get; set; }
        public long? ItemId { get; set; }
        public long? MonthKey { get; set; }
        public decimal? RevenuePlan { get; set; }
        public string SaleUnit { get; set; }
        public decimal? QuantityPlan { get; set; }
    }
}
