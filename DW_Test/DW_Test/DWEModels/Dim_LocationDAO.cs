using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_LocationDAO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
