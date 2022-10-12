using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class NCTT_Fact_KPI_SaleOut_RevenueDAO
    {
        public long Id { get; set; }
        public long? DateKey { get; set; }
        public long? EmployeeId { get; set; }
        public long? StoreId { get; set; }
        public long? KPIId { get; set; }
        public decimal? Revenue { get; set; }
    }
}
