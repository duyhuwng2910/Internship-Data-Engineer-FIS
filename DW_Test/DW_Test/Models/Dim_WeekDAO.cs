using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Dim_WeekDAO
    {
        public long WeekKey { get; set; }
        public long Week { get; set; }
        public long Year { get; set; }
        public string WeekName { get; set; }
        public long MonthKey { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
    }
}
