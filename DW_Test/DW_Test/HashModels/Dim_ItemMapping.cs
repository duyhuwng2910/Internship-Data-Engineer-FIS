using DW_Test.Models;

namespace DW_Test.HashModels
{
    public partial class Dim_ItemMapping
    {
        public long Item_MappingId { get; set; }
        public long? ItemId { get; set; }
        public string? ItemCode { get; set; }
        public long? ItemTypeId { get; set; }
        public long? ItemMainGroupId { get; set; }
        public long? ItemGroupLevel1Id { get; set; }
        public long? ItemGroupLevel2Id { get; set; }
        public long? ItemGroupLevel3Id { get; set; }
        public long? ItemLedSmartGroupId { get; set; }
        public long? ItemSingleLedSmartGroupId { get; set; }

        public string Key;

        public string GetKey()
        {
            Key = ItemCode + "_" + ItemId.ToString();

            return Key.GetHashCode().ToString();
        }

        public string Value;

        public string GetValue()
        {
            Value = ItemTypeId.ToString() + "_" +
                    ItemMainGroupId.ToString() + "_" +
                    ItemGroupLevel1Id.ToString() + "_" +
                    ItemGroupLevel2Id.ToString() + "_" +
                    ItemGroupLevel3Id.ToString() + "_" +
                    ItemLedSmartGroupId.ToString() + "_" +
                    ItemSingleLedSmartGroupId.ToString();

            return Value.GetHashCode().ToString();
        }

        public Dim_ItemMapping(Dim_ItemMappingDAO item)
        {
            ItemId = item.ItemId;
            ItemCode = item.ItemCode;
            ItemTypeId = item.ItemTypeId;
            ItemMainGroupId = item.ItemMainGroupId;
            ItemGroupLevel1Id = item.ItemGroupLevel1Id;
            ItemGroupLevel2Id = item.ItemGroupLevel2Id;
            ItemGroupLevel3Id = item.ItemGroupLevel3Id;
            ItemLedSmartGroupId = item.ItemLedSmartGroupId;
            ItemSingleLedSmartGroupId = item.ItemSingleLedSmartGroupId;
        }
    }
}
