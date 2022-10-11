using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class KPI_Fact_Result_Planned_General
    {
        public long Id { get; set; }
        public long? MonthKey { get; set; }
        public long? SaleEmployeeId { get; set; }
        public long? KPIId { get; set; }
        public decimal? Result { get; set; }
        public decimal? Planned { get; set; }
    }
}
