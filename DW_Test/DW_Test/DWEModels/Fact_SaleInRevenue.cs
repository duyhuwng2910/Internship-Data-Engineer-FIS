using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Fact_SaleInRevenue
    {
        public long Id { get; set; }
        public long? CustomerId { get; set; }
        public long? ItemId { get; set; }
        public decimal? Revenue { get; set; }
        public long? DateKey { get; set; }
        public long ProductGroupingId { get; set; }
        public long? SaleTeamId { get; set; }
        public long? OrganizationProductId { get; set; }
        public long TransactionId { get; set; }
    }
}
