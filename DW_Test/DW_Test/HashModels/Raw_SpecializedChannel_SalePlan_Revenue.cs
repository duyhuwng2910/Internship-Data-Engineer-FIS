using DW_Test.Models;

namespace DW_Test.HashModels
{
    public partial class Raw_SpecializedChannel_SalePlan_Revenue
    {
        public long Id { get; set; }
        public string TenMien { get; set; }
        public string TenKenh { get; set; }
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public decimal? KHNam { get; set; }
        public decimal? KHQuy1 { get; set; }
        public decimal? KHQuy2 { get; set; }
        public decimal? KHQuy3 { get; set; }
        public decimal? KHQuy4 { get; set; }
        public decimal? KHThang1 { get; set; }
        public decimal? KHThang2 { get; set; }
        public decimal? KHThang3 { get; set; }
        public decimal? KHThang4 { get; set; }
        public decimal? KHThang5 { get; set; }
        public decimal? KHThang6 { get; set; }
        public decimal? KHThang7 { get; set; }
        public decimal? KHThang8 { get; set; }
        public decimal? KHThang9 { get; set; }
        public decimal? KHThang10 { get; set; }
        public decimal? KHThang11 { get; set; }
        public decimal? KHThang12 { get; set; }
        public long? Nam { get; set; }

        public string Key;

        public string GetKey()
        {
            Key = TenMien + "_" + TenKenh + "_" + MaKH + "_" + TenKH;

            return Key.GetHashCode().ToString();
        }

        public string Value;

        public string GetValue()
        {
            Value = KHNam + "_" + KHQuy1 + "_" + KHQuy2 + "_" + KHQuy3 + "_" + KHQuy4
                  + KHThang1 + "_" + KHThang2 + "_" + KHThang3
                  + KHThang4 + "_" + KHThang5 + "_" + KHThang6
                  + KHThang7 + "_" + KHThang8 + "_" + KHThang9
                  + KHThang10 + "_" + KHThang11 + "_" + KHThang12;

            return Value.GetHashCode().ToString();
        }

        public Raw_SpecializedChannel_SalePlan_Revenue(Raw_SpecializedChannel_SalePlan_RevenueDAO remote)
        {
            Id = remote.Id;
            TenMien = remote.TenMien;
            TenKenh = remote.TenKenh;
            MaKH = remote.MaKH;
            TenKH = remote.TenKH;
            KHNam = remote.KHNam;
            KHQuy1 = remote.KHQuy1;
            KHQuy2 = remote.KHQuy2;
            KHQuy3 = remote.KHQuy3;
            KHQuy4 = remote.KHQuy4;
            KHThang1 = remote.KHThang1;
            KHThang2 = remote.KHThang2;
            KHThang3 = remote.KHThang3;
            KHThang4 = remote.KHThang4;
            KHThang5 = remote.KHThang5;
            KHThang6 = remote.KHThang6;
            KHThang7 = remote.KHThang7;
            KHThang8 = remote.KHThang8;
            KHThang9 = remote.KHThang9;
            KHThang10 = remote.KHThang10;
            KHThang11 = remote.KHThang11;
            KHThang12 = remote.KHThang12;
            Nam = remote.Nam;
            GetKey();
            GetValue();
        }
    }
}
