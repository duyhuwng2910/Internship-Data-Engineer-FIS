﻿using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class StateDAO
    {
        public long Id { get; set; }
        public long JobId { get; set; }
        public string Name { get; set; }
        public string Reason { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Data { get; set; }

        public virtual JobDAO Job { get; set; }
    }
}
