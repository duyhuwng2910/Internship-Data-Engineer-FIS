using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Dim_MonthDAO
    {
        public long MonthKey { get; set; }
        public long Month { get; set; }
        public long Year { get; set; }
        public string MonthName { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
    }
}
