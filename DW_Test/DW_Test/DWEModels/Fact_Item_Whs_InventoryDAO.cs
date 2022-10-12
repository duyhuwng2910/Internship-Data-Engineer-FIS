using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_Item_Whs_InventoryDAO
    {
        public long Id { get; set; }
        public long? ItemId { get; set; }
        public long? UnitPrice { get; set; }
        public long? WarehouseId { get; set; }
        public long? ActualInventory { get; set; }
        public long? StockInventory { get; set; }
        public long? ActualInventoryValue { get; set; }
        public long? StockInventoryValue { get; set; }
    }
}
