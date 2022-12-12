using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_C4LED_SalePlan_QuarterDAO
    {
        public long Id { get; set; }
        public long? SaleUnitId { get; set; }
        public long? SaleCenterId { get; set; }
        public long SaleArrayId { get; set; }
        public long QuarterKey { get; set; }
        public decimal? Plan { get; set; }
    }
}
