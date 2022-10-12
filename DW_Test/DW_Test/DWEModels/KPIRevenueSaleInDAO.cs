using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class KPIRevenueSaleInDAO
    {
        public long Id { get; set; }
        public long? DateKey { get; set; }
        public long MonthKey { get; set; }
        public long? CustomerId { get; set; }
        public long? KPIId { get; set; }
        public decimal? Revenue { get; set; }
    }
}
