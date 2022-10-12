using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_IndirectSalesOrderStoreGroupingMappingDAO
    {
        public long IndirectSalesOrderStoreGroupingId { get; set; }
        public long IndirectSalesOrderId { get; set; }
        public long StoreGroupingId { get; set; }
    }
}
