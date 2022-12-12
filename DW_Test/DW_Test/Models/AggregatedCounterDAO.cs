using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class AggregatedCounterDAO
    {
        public string Key { get; set; }
        public long Value { get; set; }
        public DateTime? ExpireAt { get; set; }
    }
}
