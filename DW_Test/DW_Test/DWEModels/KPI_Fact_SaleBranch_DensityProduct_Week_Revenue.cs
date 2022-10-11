using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class KPI_Fact_SaleBranch_DensityProduct_Week_Revenue
    {
        public decimal? Revenue { get; set; }
        public long SaleBranchId { get; set; }
        public int KPITypeId { get; set; }
        public long? WeekKey { get; set; }
    }
}
