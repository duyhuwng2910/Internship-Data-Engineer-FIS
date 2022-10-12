using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Dim_YearDAO
    {
        public long Id { get; set; }
        public long Year { get; set; }
        public DateTime? StartAt { get; set; }
        public DateTime? EndAt { get; set; }
    }
}
