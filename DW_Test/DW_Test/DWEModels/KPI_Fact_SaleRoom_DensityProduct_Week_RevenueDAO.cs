using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class KPI_Fact_SaleRoom_DensityProduct_Week_RevenueDAO
    {
        public decimal? Revenue { get; set; }
        public long SaleRoomId { get; set; }
        public int KPITypeId { get; set; }
        public long? WeekKey { get; set; }
    }
}
