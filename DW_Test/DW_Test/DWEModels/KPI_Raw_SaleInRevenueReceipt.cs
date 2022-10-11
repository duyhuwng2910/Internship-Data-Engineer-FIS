using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class KPI_Raw_SaleInRevenueReceipt
    {
        public long Id { get; set; }
        public long? Year { get; set; }
        public long? Month { get; set; }
        public string County { get; set; }
        public string KPI { get; set; }
        public decimal? Revenue { get; set; }
    }
}
