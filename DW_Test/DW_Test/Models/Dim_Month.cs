using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.Models
{
    public partial class Dim_Month
    {
        public long MonthKey { get; set; }
        public long Month { get; set; }
        public long Year { get; set; }
        public string MonthName { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
    }
}
