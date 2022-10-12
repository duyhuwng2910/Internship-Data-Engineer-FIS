using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_ItemMappingDAO
    {
        public long MappingId { get; set; }
        public long? ItemId { get; set; }
        public long? ItemTypeId { get; set; }
        public long? ItemMainGroupId { get; set; }
        public long? ItemGroupLevel1Id { get; set; }
        public long? ItemGroupLevel2Id { get; set; }
        public long? ItemGroupLevel3Id { get; set; }
        public long? ItemLedSmartGroupId { get; set; }
        public long? ItemSingleSmartGroupId { get; set; }
        public long? ItemVATGroupId { get; set; }
        public long? ItemNewItemGroupId { get; set; }
        public long? ItemNCTTId { get; set; }
        public long? M_StartDateKey { get; set; }
        public long? M_EndDateKey { get; set; }
        public long? GTGT_StartDateKey { get; set; }
        public long? GTGT_EndDateKey { get; set; }

        public virtual Dim_ItemDAO Item { get; set; }
        public virtual Dim_ItemSingleSmartGroupDAO ItemSingleSmartGroup { get; set; }
        public virtual Dim_ItemTypeDAO ItemType { get; set; }
    }
}
