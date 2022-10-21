using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Dim_Date_MappingDAO
    {
        public long DateKey { get; set; }
        public long? MonthKey { get; set; }
        public long? QuarterKey { get; set; }
        public DateTime? Date { get; set; }
        public long? Day { get; set; }
        public long? Month { get; set; }
        public long? Quarter { get; set; }
        public long? Year { get; set; }
    }
}
