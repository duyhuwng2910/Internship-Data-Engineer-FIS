using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Raw_TeamSale_Employee
    {
        public long Id { get; set; }
        public string MA_NV { get; set; }
        public string TEN_NV { get; set; }
        public string TEN_DOI { get; set; }
        public DateTime START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
    }
}
