using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class NCTT_Fact_RevenueDAO
    {
        public long Id { get; set; }
        public string OrderId { get; set; }
        public long? DateKey { get; set; }
        public long? ItemId { get; set; }
        public long? CustomerId { get; set; }
        public decimal? Quantity { get; set; }
        public long? ManagePrice { get; set; }
        public long? ActualPrice { get; set; }
        public long? Revenue { get; set; }
        public long? SourceId { get; set; }
        public long? InputSourceId { get; set; }
        public long? RawId { get; set; }
        public long? ItemVATGroupId { get; set; }
        public long? ItemNewItemGroupId { get; set; }
    }
}
