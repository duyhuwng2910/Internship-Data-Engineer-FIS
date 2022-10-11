using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class TMDT_Raw_Order
    {
        public long Id { get; set; }
        public string MA_DHANG { get; set; }
        public DateTime? NGAY_TAO { get; set; }
        public string NGUON_BHANG { get; set; }
        public string TRANG_THAI { get; set; }
        public string DVI_XLY { get; set; }
        public string MA_KHANG { get; set; }
        public string TEN_KHANG { get; set; }
        public string DTHOAI { get; set; }
        public string DCHI { get; set; }
        public string TINH_THANHPHO { get; set; }
        public decimal? SOLUONG { get; set; }
        public decimal? DGIA { get; set; }
        public decimal? TONG_TIEN { get; set; }
        public string MA_SAP { get; set; }
        public string TEN_SP { get; set; }
        public string Ngay_RAW { get; set; }
        public string MA_PHIENBAN { get; set; }
    }
}
