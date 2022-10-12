using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class KPI_Fact_SaleInRevenueC1NewProduct_PlanDAO
    {
        public long Id { get; set; }
        public long? MonthId { get; set; }
        public long? CustomerId { get; set; }
        public long? KPIId { get; set; }
        public decimal? Plan { get; set; }
    }
}
