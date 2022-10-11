using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Fact_Incur_Revenue
    {
        public long Id { get; set; }
        public long? ItemId { get; set; }
        public long? CustomerId { get; set; }
        public long? SaleChannelId { get; set; }
        public long? DateKey { get; set; }
        public string OrderId { get; set; }
        public long? Quantity { get; set; }
        public long? UnitPrice { get; set; }
        public long? Revenue { get; set; }
        public long? InputSourceId { get; set; }
        public long? SaleRoomId { get; set; }
        public long? SaleBranchId { get; set; }
        public long? CountyId { get; set; }
        public long? EmployeeId { get; set; }
        public long? ItemNewItemGroupId { get; set; }
        public long? ItemVATGroupId { get; set; }
    }
}
