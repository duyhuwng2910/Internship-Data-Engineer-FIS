using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Fact_ProductGrouping
    {
        public long Id { get; set; }
        public long ItemId { get; set; }
        public long ProductGroupingId { get; set; }
        public long OrganizationId { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public long? PeriodId { get; set; }
    }
}
