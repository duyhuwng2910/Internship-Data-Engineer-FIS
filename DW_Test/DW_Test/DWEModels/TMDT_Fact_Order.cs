using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class TMDT_Fact_Order
    {
        public long Id { get; set; }
        public long? OrderId { get; set; }
        public DateTime? Date { get; set; }
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
