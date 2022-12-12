using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Dim_SpecializedChannelMappingDAO
    {
        public long MappingId { get; set; }
        public long? RegionId { get; set; }
        public long? SaleChannelId { get; set; }
    }
}
