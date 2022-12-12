using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class TMDT_Fact_OrderDAO
    {
        public long Id { get; set; }
        public long? OrderId { get; set; }
        public DateTime? Date { get; set; }
        public string OrderCode { get; set; }
        public long? OrderSourceId { get; set; }
        public long? OrderStatusId { get; set; }
        public long? ProcessingDepartmentId { get; set; }
        public long? CustomerId { get; set; }
        public long? CityId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? Revenue { get; set; }
        public long? ItemId { get; set; }
        public long? ItemNewItemGroupId { get; set; }
        public long? ItemVATGroupId { get; set; }
        public string OrderValue { get; set; }
    }
}
