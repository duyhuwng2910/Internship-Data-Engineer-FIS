using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Fact_Report_RevenueDAO
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public long DateKey { get; set; }
        public long ItemId { get; set; }
        public long Quantity { get; set; }
        public long UnitPrice { get; set; }
        public decimal Revenue { get; set; }
        public long? ItemVATGroupId { get; set; }
        public long? ItemNewItemGroupId { get; set; }
    }
}
