using Raw_A009DAO = DW_Test.Models.Raw_A009DAO;

namespace DW_Test.HashModels
{
    public partial class Raw_A009
    {
        public long Id { get; set; }
        public string Nhom_SP { get; set; }
        public string Loai_SP { get; set; }
        public string TenThuKho { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public decimal? Nhap { get; set; }
        public decimal? NhapLKThang { get; set; }
        public decimal? XuatChungTu { get; set; }
        public decimal? XuatChungTuLKThang { get; set; }
        public decimal? ThucXuat { get; set; }
        public decimal? ThucXuatLKThang { get; set; }
        public decimal? XuatBan { get; set; }
        public decimal? XuatBanLKThang { get; set; }
        public decimal? TonChungTu { get; set; }
        public decimal? TonThucTe { get; set; }
        public decimal? HangGui { get; set; }
        public string WhsCode { get; set; }

        public string Key;

        public string GetKey()
        {
            Key = ItemCode + "_" + WhsCode;

            return Key.GetHashCode().ToString();
        }

        public string Value;

        public string GetValue()
        {
            Value = Nhom_SP + "_" +
                    Loai_SP + "_" +
                    TenThuKho + "_" +
                    ItemName + "_" +
                    Nhap + "_" +
                    NhapLKThang + "_" +
                    XuatChungTu + "_" +
                    XuatChungTuLKThang + "_" +
                    ThucXuat + "_" +
                    ThucXuatLKThang + "_" +
                    XuatBan + "_" +
                    XuatBanLKThang + "_" +
                    TonChungTu + "_" +
                    TonThucTe + "_" +
                    HangGui;

            return Value.GetHashCode().ToString();
        }

        public Raw_A009(Raw_A009DAO remote)
        {
            Id = remote.Id;
            Nhom_SP = remote.Nhom_SP;
            Loai_SP = remote.Loai_SP;
            TenThuKho = remote.TenThuKho;
            ItemCode = remote.ItemCode;
            ItemName = remote.ItemName;
            Nhap = remote.Nhap;
            NhapLKThang = remote.NhapLKThang;
            XuatChungTu = remote.XuatChungTu;
            XuatChungTuLKThang = remote.XuatChungTuLKThang;
            ThucXuat = remote.ThucXuat;
            ThucXuatLKThang = remote.ThucXuatLKThang;
            XuatBan = remote.XuatBan;
            XuatBanLKThang = remote.XuatBanLKThang;
            TonChungTu = remote.TonChungTu;
            TonThucTe = remote.TonThucTe;
            HangGui = remote.HangGui;
            WhsCode = remote.WhsCode;
            GetKey();
            GetValue();
        }

        public Raw_A009(DWEModels.Raw_A009DAO remote)
        {
            Id = remote.Id;
            Nhom_SP = remote.Nhom_SP;
            Loai_SP = remote.Loai_SP;
            TenThuKho = remote.TenThuKho;
            ItemCode = remote.ItemCode;
            ItemName = remote.ItemName;
            Nhap = remote.Nhap;
            NhapLKThang = remote.NhapLKThang;
            XuatChungTu = remote.XuatChungTu;
            XuatChungTuLKThang = remote.XuatChungTuLKThang;
            ThucXuat = remote.ThucXuat;
            ThucXuatLKThang = remote.ThucXuatLKThang;
            XuatBan = remote.XuatBan;
            XuatBanLKThang = remote.XuatBanLKThang;
            TonChungTu = remote.TonChungTu;
            TonThucTe = remote.TonThucTe;
            HangGui = remote.HangGui;
            WhsCode = remote.WhsCode;
            GetKey();
            GetValue();
        }
    }
}
