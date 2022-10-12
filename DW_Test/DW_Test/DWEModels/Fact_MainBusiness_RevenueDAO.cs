using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_MainBusiness_RevenueDAO
    {
        public long Id { get; set; }
        public long? MainBusinessId { get; set; }
        public long? DateKey { get; set; }
        public decimal? Revenue { get; set; }
    }
}
