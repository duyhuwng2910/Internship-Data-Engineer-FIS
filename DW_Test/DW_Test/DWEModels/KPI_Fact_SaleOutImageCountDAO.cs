using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class KPI_Fact_SaleOutImageCountDAO
    {
        public long Id { get; set; }
        public long? DateKey { get; set; }
        public long? EmployeeId { get; set; }
        public long? KPIId { get; set; }
        public long? Revenue { get; set; }
    }
}
