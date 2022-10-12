using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class KPI_Fact_SaleInRevenueReceiptDAO
    {
        public long SaleIn_Receipt_RevenueId { get; set; }
        public long? MonthKey { get; set; }
        public long? CustomerId { get; set; }
        public long? KPIId { get; set; }
        public decimal? Revenue { get; set; }
    }
}
