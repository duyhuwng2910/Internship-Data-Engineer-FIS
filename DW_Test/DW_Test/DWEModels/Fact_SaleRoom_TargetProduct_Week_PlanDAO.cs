using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_SaleRoom_TargetProduct_Week_PlanDAO
    {
        public long Id { get; set; }
        public long? SaleRoomId { get; set; }
        public long? ItemGroupLevelId { get; set; }
        public long? ParentId { get; set; }
        public long? WeekKey { get; set; }
        public decimal? RevenuePlan { get; set; }
    }
}
