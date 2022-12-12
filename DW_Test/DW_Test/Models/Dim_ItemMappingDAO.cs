using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Dim_ItemMappingDAO
    {
        public long Item_MappingId { get; set; }
        public long? ItemId { get; set; }
        public string ItemCode { get; set; }
        public long? ItemTypeId { get; set; }
        public long? ItemMainGroupId { get; set; }
        public long? ItemGroupLevel1Id { get; set; }
        public long? ItemGroupLevel2Id { get; set; }
        public long? ItemGroupLevel3Id { get; set; }
        public long? ItemLedSmartGroupId { get; set; }
        public long? ItemSingleLedSmartGroupId { get; set; }
    }
}
