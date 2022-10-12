using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class NCTT_Raw_CountyScopeDAO
    {
        public long Id { get; set; }
        public string County { get; set; }
        public long? Population { get; set; }
        public decimal? Area { get; set; }
        public decimal? GRDP { get; set; }
        public decimal? FDI { get; set; }
        public decimal? UrbanizationRate { get; set; }
    }
}
