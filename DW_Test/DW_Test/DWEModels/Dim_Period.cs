using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Dim_Period
    {
        public long PeriodId { get; set; }
        public long Year { get; set; }
        public string PeriodName { get; set; }
        public string PeriodGroupingName { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public string QuarterName { get; set; }
        public string MonthName { get; set; }
        public long? OrderNumber { get; set; }
        public long? OrderNumberMonth { get; set; }
        public string PeriodCode { get; set; }
        public long? PeriodTypeId { get; set; }
    }
}
