using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class KPI_Fact_RevenueDAO
    {
        public long? DateKey { get; set; }
        public int KPITypeId { get; set; }
        public long? Revenue { get; set; }
        public long? SaleBranchId { get; set; }
        public long? SaleRoomId { get; set; }
    }
}
