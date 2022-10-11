using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Dim_DateMapping
    {
        public long DateKey { get; set; }
        public long? MonthKey { get; set; }
        public long? QuarterKey { get; set; }
        public DateTime? Date { get; set; }
        public long? Day { get; set; }
        public long? Month { get; set; }
        public long? Quarter { get; set; }
        public long? Year { get; set; }
        public long? WeekKey { get; set; }
    }
}
