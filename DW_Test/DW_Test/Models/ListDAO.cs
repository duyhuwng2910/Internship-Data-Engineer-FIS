using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class ListDAO
    {
        public long Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime? ExpireAt { get; set; }
    }
}
