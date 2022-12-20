using DW_Test.Models;

namespace DW_Test.HashModels
{
    public partial class Raw_Product_ProductGroup
    {
        public long Id { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string SPC1 { get; set; }
        public string SPC2 { get; set; }
        public string CongSuat { get; set; }
        public string NhietDoMau { get; set; }
        public string ChatLuong { get; set; }

        public string Key;

        public string GetKey()
        {
            Key = MaSP + "_" + TenSP;

            return Key.GetHashCode().ToString();
        }

        public string Value;

        public string GetValue()
        {
            Value = SPC1 + "_" + SPC2 + "_" + CongSuat + "_" + NhietDoMau + "_" + ChatLuong;

            return Value.GetHashCode().ToString();
        }

        public Raw_Product_ProductGroup(Raw_Product_ProductGroupDAO remote)
        {
            Id = remote.Id;
            MaSP = remote.MaSP;
            TenSP = remote.TenSP;
            SPC1 = remote.SPC1;
            SPC2 = remote.SPC2;
            CongSuat = remote.CongSuat;
            NhietDoMau = remote.NhietDoMau;
            ChatLuong = remote.ChatLuong;
            GetKey();
            GetValue();
        }
    }
}
