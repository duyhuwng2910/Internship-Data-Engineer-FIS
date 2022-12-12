using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Fact_RD_CustomerMonthPlanDAO
    {
        public long Id { get; set; }
        public long? CustomerId { get; set; }
        public long? MonthKey { get; set; }
        public decimal? RevenuePlan { get; set; }
    }
}
