using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Dim_KPI_ProductGrouping
    {
        public long ProductGroupingId { get; set; }
        public string ProductGroupingCode { get; set; }
        public string ProductGroupingName { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
