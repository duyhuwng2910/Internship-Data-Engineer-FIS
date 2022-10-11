using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
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
    }
}
