using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Raw_ProductGroup
    {
        public long Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Loai_MHang_KH { get; set; }
        public string NhomChinh_KH { get; set; }
        public string NhomC1 { get; set; }
        public string NhomC2 { get; set; }
        public string NhomC3 { get; set; }
        public string Nhom_LEDSMRT1 { get; set; }
        public string Nhom_SMRTDONLEHT { get; set; }
        public DateTime? M_StartDate { get; set; }
        public DateTime? M_EndDate { get; set; }
        public DateTime? GTGT_StartDate { get; set; }
        public DateTime? GTGT_EndDate { get; set; }
        public string NCTT { get; set; }
    }
}
