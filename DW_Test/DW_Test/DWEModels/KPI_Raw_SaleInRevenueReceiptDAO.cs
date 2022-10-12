using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class KPI_Raw_SaleInRevenueReceiptDAO
    {
        public long Id { get; set; }
        public long? Year { get; set; }
        public long? Month { get; set; }
        public string County { get; set; }
        public string KPI { get; set; }
        public decimal? Revenue { get; set; }
    }
}
