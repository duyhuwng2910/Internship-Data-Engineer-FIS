using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class NCTT_Fact_CountyScopeDAO
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
