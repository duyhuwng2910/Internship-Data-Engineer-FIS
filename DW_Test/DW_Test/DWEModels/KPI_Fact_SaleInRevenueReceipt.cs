using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class KPI_Fact_SaleInRevenueReceipt
    {
        public long SaleIn_Receipt_RevenueId { get; set; }
        public long? MonthKey { get; set; }
        public long? CustomerId { get; set; }
        public long? KPIId { get; set; }
        public decimal? Revenue { get; set; }
    }
}
