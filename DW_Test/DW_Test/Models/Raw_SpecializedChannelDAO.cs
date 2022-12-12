using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Raw_SpecializedChannelDAO
    {
        public long Id { get; set; }
        public string MaMien { get; set; }
        public string TenMien { get; set; }
        public string MaKenh { get; set; }
        public string TenKenh { get; set; }
        public decimal? SPC1 { get; set; }
    }
}
