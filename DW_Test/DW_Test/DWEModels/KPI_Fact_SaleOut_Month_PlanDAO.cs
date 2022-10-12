using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class KPI_Fact_SaleOut_Month_PlanDAO
    {
        public long Id { get; set; }
        public long? MonthKey { get; set; }
        public long? KPIId { get; set; }
        public long? SaleEmployeeId { get; set; }
        public decimal? Plan { get; set; }
    }
}
