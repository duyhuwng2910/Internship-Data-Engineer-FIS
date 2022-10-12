using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_Item_MinimumInventoryDAO
    {
        public long Id { get; set; }
        public long? ItemId { get; set; }
        public decimal? MinInventory { get; set; }
    }
}
