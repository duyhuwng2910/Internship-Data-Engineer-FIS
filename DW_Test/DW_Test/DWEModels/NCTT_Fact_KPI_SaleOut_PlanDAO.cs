using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class NCTT_Fact_KPI_SaleOut_PlanDAO
    {
        public long Id { get; set; }
        public long? MonthId { get; set; }
        public long? CountyId { get; set; }
        public long? KPIId { get; set; }
        public decimal? Plan { get; set; }
    }
}
