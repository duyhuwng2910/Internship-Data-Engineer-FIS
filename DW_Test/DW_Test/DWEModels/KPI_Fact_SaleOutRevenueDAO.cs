using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class KPI_Fact_SaleOutRevenueDAO
    {
        public long Id { get; set; }
        public long StoreId { get; set; }
        public long DateKey { get; set; }
        public long SaleEmployeeId { get; set; }
        public long? StoreCheckingId { get; set; }
        public string Action { get; set; }
        public long? Image { get; set; }
        public long? Problem { get; set; }
        public decimal? TotalValue { get; set; }
    }
}
