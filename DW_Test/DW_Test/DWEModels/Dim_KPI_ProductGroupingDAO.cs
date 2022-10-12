using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_KPI_ProductGroupingDAO
    {
        public long ProductGroupingId { get; set; }
        public string ProductGroupingCode { get; set; }
        public string ProductGroupingName { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
