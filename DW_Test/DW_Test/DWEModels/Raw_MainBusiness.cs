using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Raw_MainBusiness
    {
        public long Id { get; set; }
        public DateTime? Thoidiem { get; set; }
        public string Trucot { get; set; }
        public decimal? Doanhthu { get; set; }
    }
}
