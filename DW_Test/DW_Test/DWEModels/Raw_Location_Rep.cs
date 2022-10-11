﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Raw_Location_Rep
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string U_Location { get; set; }
        public string U_Kho { get; set; }
    }
}
