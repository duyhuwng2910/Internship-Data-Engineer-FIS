using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class NCTT_Dim_ItemMapping
    {
        public long ItemMappingId { get; set; }
        public long? ItemId { get; set; }
        public long? ItemPrice { get; set; }
        public bool? ItemNew { get; set; }
        public long? ItemClassId { get; set; }
        public long? ItemGroupId { get; set; }
        public long? ItemLineId { get; set; }
        public long? ItemPropertyGroupId { get; set; }
        public long? ItemPropertyDetailId { get; set; }
        public long? ItemCharacteristicId { get; set; }
        public long? ItemTypeId { get; set; }
    }
}
