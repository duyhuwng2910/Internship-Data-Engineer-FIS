using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Fact_Company_Quarter_PlanDAO
    {
        public long Id { get; set; }
        public long QuarterKey { get; set; }
        public decimal? Revenue { get; set; }
    }
}
