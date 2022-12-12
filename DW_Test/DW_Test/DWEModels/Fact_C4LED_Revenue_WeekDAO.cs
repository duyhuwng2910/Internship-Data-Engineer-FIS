using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_C4LED_Revenue_WeekDAO
    {
        public long Id { get; set; }
        public long SaleUnitMappingId { get; set; }
        public long SaleArrayId { get; set; }
        public long SaleFieldId { get; set; }
        public long WeekKey { get; set; }
        public decimal? Revenue { get; set; }
    }
}
