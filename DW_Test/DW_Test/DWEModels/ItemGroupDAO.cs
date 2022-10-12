using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class ItemGroupDAO
    {
        public long Id { get; set; }
        public long? ItemId { get; set; }
        public long? CustomerId { get; set; }
        public long? DateKey { get; set; }
        public string OrderId { get; set; }
        public long? Quantity { get; set; }
        public long? UnitPrice { get; set; }
        public long? Revenue { get; set; }
        public long? InputSourceId { get; set; }
        public long? ItemNewItemGroupId { get; set; }
        public long? ItemVATGroupId { get; set; }
        public long? RawId { get; set; }
        public long? ItemGroupId { get; set; }
        public long? calculateid { get; set; }
        public string ItemGroupName { get; set; }
    }
}
