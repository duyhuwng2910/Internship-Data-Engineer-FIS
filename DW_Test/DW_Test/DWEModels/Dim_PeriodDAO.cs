using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_PeriodDAO
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
        public string PeriodBIName { get; set; }
    }
}
