using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Fact_Customer_Year_PlanDAO
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public long YearKey { get; set; }
        public long? Quantity { get; set; }
        public long? UnitPrice { get; set; }
        public decimal? Revenue { get; set; }
    }
}
