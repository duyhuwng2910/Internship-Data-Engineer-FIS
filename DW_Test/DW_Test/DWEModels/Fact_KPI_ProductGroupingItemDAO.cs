using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_KPI_ProductGroupingItemDAO
    {
        public long Id { get; set; }
        public long ItemId { get; set; }
        public long ProductGroupingId { get; set; }
        public long? OrganizationId { get; set; }
        public long PeriodId { get; set; }
    }
}
