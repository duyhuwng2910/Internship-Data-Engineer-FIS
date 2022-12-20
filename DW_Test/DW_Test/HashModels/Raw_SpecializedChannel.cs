using DW_Test.Models;

namespace DW_Test.HashModels
{
    public partial class Raw_SpecializedChannel
    {
        public long Id { get; set; }
        public string TenMien { get; set; }
        public string TenKenh { get; set; }
        public string SPC1 { get; set; }

        public string Key;

        public string GetKey()
        {
            Key = TenMien + "_" + TenKenh;

            return Key.GetHashCode().ToString();
        }

        public string Value;

        public string GetValue()
        {
            Value = SPC1;

            return Value.GetHashCode().ToString();
        }

        public Raw_SpecializedChannel(Raw_SpecializedChannelDAO remote)
        {
            Id = remote.Id;
            TenMien = remote.TenMien;
            TenKenh = remote.TenKenh;
            SPC1 = remote.SPC1;
            GetKey();
            GetValue();
        }
    }
}
