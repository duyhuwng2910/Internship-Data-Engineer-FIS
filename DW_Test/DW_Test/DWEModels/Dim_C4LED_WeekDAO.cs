using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_C4LED_WeekDAO
    {
        public long WeekKey { get; set; }
        public string WeekName { get; set; }
        public long Week { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string MonthName { get; set; }
        public long MonthKey { get; set; }
        public string QuarterName { get; set; }
        public long QuarterKey { get; set; }
        public long Year { get; set; }
    }
}
