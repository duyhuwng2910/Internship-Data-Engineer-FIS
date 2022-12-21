using DW_Test.Models;

namespace DW_Test.HashModels
{
    public partial class Dim_RD_Item
    {
        public long ItemId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Quality { get; set; }
        public string Performance { get; set; }
        public string LightColor { get; set; }
        public decimal? UnitPrice { get; set; }

        public string Key;

        public string GetKey()
        {
            Key = ItemCode;

            return Key.GetHashCode().ToString();
        }

        public string Value;

        public string GetValue()
        {
            Value = ItemName + "_" + 
                    Quality + "_" + 
                    Performance + "_" +
                    LightColor + "_" +
                    UnitPrice;

            return Value.GetHashCode().ToString();
        }

        public Dim_RD_Item(Dim_RD_ItemDAO remote)
        {
            ItemId = remote.ItemId;
            ItemCode = remote.ItemCode;
            ItemName = remote.ItemName;
            Quality = remote.Quality;
            Performance = remote.Performance;
            LightColor = remote.LightColor;
            UnitPrice = remote.UnitPrice;
            GetKey();
            GetValue();
        }
    }
}
