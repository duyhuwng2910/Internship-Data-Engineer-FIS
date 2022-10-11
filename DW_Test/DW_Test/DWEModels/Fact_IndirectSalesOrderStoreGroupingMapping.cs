using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Fact_IndirectSalesOrderStoreGroupingMapping
    {
        public long IndirectSalesOrderStoreGroupingId { get; set; }
        public long IndirectSalesOrderId { get; set; }
        public long StoreGroupingId { get; set; }
    }
}
