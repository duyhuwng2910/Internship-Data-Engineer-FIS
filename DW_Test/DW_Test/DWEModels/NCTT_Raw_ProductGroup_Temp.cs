using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class NCTT_Raw_ProductGroup_Temp
    {
        public long Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public long? ItemPrice { get; set; }
        public string ItemClass { get; set; }
        public string ItemGroup { get; set; }
        public string ItemLine { get; set; }
        public string Kieu_dang { get; set; }
        public string Chung_loai { get; set; }
        public string Cong_suat { get; set; }
        public string Dac_tinh { get; set; }
        public string Loai { get; set; }
        public string GTGT { get; set; }
    }
}
