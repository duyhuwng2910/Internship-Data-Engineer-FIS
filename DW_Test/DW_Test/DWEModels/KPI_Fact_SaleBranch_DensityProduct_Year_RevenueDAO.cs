using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class KPI_Fact_SaleBranch_DensityProduct_Year_RevenueDAO
    {
        public decimal? Revenue { get; set; }
        public long SaleBranchId { get; set; }
        public int KPITypeId { get; set; }
        public long? Year { get; set; }
    }
}
