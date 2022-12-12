using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_Item_Whs_ConsignmentDAO
    {
        public long Id { get; set; }
        public long ItemId { get; set; }
        public long WarehouseId { get; set; }
        public decimal? Consignment { get; set; }
        public long CustomerId { get; set; }
    }
}
