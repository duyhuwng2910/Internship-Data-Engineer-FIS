using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_C4LED_SalePlan_YearDAO
    {
        public long Id { get; set; }
        public long SaleUnitId { get; set; }
        public long? SaleArrayId { get; set; }
        public long Year { get; set; }
        public decimal? Plan { get; set; }
    }
}
