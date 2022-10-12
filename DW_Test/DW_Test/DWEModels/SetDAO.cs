using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class SetDAO
    {
        public string Key { get; set; }
        public double Score { get; set; }
        public string Value { get; set; }
        public DateTime? ExpireAt { get; set; }
    }
}
