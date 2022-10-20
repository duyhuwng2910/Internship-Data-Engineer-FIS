using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Raw_Product_GroupDAO
    {
        public long Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Loai_MHang_KH { get; set; }
        public string Nhomchinh_KH { get; set; }
        public string NhomC1 { get; set; }
        public string NhomC2 { get; set; }
        public string NhomC3 { get; set; }
        public string Nhom_LEDSMRT1 { get; set; }
        public string Nhom_SMARTDONLE { get; set; }
        public DateTime? M_StartDate { get; set; }
        public DateTime? M_EndDate { get; set; }
        public DateTime? GTGT_StartDate { get; set; }
        public DateTime? GTGT_Endate { get; set; }
    }
}
