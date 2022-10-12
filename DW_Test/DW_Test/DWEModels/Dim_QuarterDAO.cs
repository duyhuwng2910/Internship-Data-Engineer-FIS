using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_QuarterDAO
    {
        public long QuarterKey { get; set; }
        public long? Quarter { get; set; }
        public long Year { get; set; }
        public string QuarterName { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
    }
}
