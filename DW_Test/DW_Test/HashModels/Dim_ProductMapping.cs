using DW_Test.Models;

namespace DW_Test.HashModels
{
    public partial class Dim_ProductMapping
    {
        public long MappingId { get; set; }
        public long ItemId { get; set; }
        public long? ItemGroupLevel1Id { get; set; }
        public long? ItemGroupLevel2Id { get; set; }

        public string Key;

        public string GetKey()
        {
            Key = ItemId.ToString();

            return Key.GetHashCode().ToString();
        }

        public string Value;

        public string GetValue()
        {
            Value = ItemGroupLevel1Id + "_" + ItemGroupLevel2Id;

            return Value.GetHashCode().ToString(); 
        }

        public Dim_ProductMapping(Dim_ProductMappingDAO remote)
        {
            MappingId = remote.MappingId;
            ItemId = remote.ItemId;
            ItemGroupLevel1Id = remote.ItemGroupLevel1Id;
            ItemGroupLevel2Id = remote.ItemGroupLevel2Id;
            GetKey();
            GetValue();
        }
    }
}
