using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_RevenueCustomerC2DAO
    {
        public long Id { get; set; }
        public long? DateKey { get; set; }
        public long? ItemId { get; set; }
        public long? CustomerId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Revenue { get; set; }
        public decimal? UnitPrice { get; set; }
        public long? IndirectSalesOrderId { get; set; }
        public long? IndirectSalesOrderTransactionId { get; set; }
        public long? ItemNewItemGroupId { get; set; }
        public long? ItemVATGroupId { get; set; }
    }
}
