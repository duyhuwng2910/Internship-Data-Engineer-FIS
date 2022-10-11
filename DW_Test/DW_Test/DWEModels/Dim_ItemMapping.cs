using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Dim_ItemMapping
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

        public virtual Dim_Item Item { get; set; }
        public virtual Dim_ItemSingleSmartGroup ItemSingleSmartGroup { get; set; }
        public virtual Dim_ItemType ItemType { get; set; }
    }
}
