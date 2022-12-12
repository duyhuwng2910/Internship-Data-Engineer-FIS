﻿using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class HashDAO
    {
        public string Key { get; set; }
        public string Field { get; set; }
        public string Value { get; set; }
        public DateTime? ExpireAt { get; set; }
    }
}
