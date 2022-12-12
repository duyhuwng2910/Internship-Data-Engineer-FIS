using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_SaleIn_ActualRevenueDAO
    {
        public long Id { get; set; }
        public long ActualRevenueId { get; set; }
        public long ItemId { get; set; }
        public long CustomerId { get; set; }
        public long DateKey { get; set; }
        public long? Quantity { get; set; }
        public long? UnitPrice { get; set; }
        public long? Revenue { get; set; }
        public long? SaleChannelId { get; set; }
        public long? SaleBranchId { get; set; }
        public long? SaleRoomId { get; set; }
        public long? CountyId { get; set; }
        public long ProductGroupingId { get; set; }
        public long SaleTeamId { get; set; }
        public long KPISaleBranchId { get; set; }
        public long KPISaleRoomId { get; set; }
    }
}
