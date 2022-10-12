using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Dim_DateDAO
    {
        public long DateKey { get; set; }
        public DateTime? Date { get; set; }
        public long? Day { get; set; }
        public long? Month { get; set; }
        public long? Year { get; set; }
    }
}
