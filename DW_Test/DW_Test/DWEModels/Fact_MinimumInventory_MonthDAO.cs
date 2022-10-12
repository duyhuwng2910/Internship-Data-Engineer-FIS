using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_MinimumInventory_MonthDAO
    {
        public long Id { get; set; }
        public long? ItemId { get; set; }
        public long? WarehouseId { get; set; }
        public long? MonthKey { get; set; }
        public decimal? MinimumInventory { get; set; }
    }
}
