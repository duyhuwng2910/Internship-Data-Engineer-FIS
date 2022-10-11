using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class NCTT_Fact_KPI_SaleOut_Revenue
    {
        public long Id { get; set; }
        public long? DateKey { get; set; }
        public long? EmployeeId { get; set; }
        public long? StoreId { get; set; }
        public long? KPIId { get; set; }
        public decimal? Revenue { get; set; }
    }
}
