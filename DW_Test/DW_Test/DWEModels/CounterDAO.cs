﻿using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class CounterDAO
    {
        public string Key { get; set; }
        public int Value { get; set; }
        public DateTime? ExpireAt { get; set; }
    }
}
