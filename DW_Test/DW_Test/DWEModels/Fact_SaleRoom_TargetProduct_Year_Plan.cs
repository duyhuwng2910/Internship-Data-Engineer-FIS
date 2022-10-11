using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Fact_SaleRoom_TargetProduct_Year_Plan
    {
        public long Id { get; set; }
        public long? SaleRoomId { get; set; }
        public long? ItemGroupLevelId { get; set; }
        public long? ParentId { get; set; }
        public long? Year { get; set; }
        public decimal? RevenuePlan { get; set; }
    }
}
