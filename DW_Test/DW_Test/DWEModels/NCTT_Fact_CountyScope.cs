﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class NCTT_Fact_CountyScope
    {
        public long CountyScopeId { get; set; }
        public long? CountyId { get; set; }
        public long? Population { get; set; }
        public decimal? Area { get; set; }
        public decimal? GRDP { get; set; }
        public decimal? FDI { get; set; }
        public decimal? UrbanizationRate { get; set; }
    }
}
