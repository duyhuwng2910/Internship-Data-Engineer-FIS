using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class KPI_Fact_SaleRoom_DensityProduct_Quarter_RevenueDAO
    {
        public decimal? Revenue { get; set; }
        public long SaleRoomId { get; set; }
        public int KPITypeId { get; set; }
        public long? QuarterKey { get; set; }
    }
}
