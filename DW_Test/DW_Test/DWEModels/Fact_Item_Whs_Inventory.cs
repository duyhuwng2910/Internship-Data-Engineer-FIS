using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Fact_Item_Whs_Inventory
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
