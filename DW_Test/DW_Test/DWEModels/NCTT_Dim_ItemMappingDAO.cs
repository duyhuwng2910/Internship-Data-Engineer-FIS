using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class NCTT_Dim_ItemMappingDAO
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
