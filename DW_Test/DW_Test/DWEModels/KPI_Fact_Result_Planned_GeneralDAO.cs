using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class KPI_Fact_Result_Planned_GeneralDAO
    {
        public long Id { get; set; }
        public long? MonthKey { get; set; }
        public long? SaleEmployeeId { get; set; }
        public long? KPIId { get; set; }
        public decimal? Result { get; set; }
        public decimal? Planned { get; set; }
    }
}
