using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Dim_ProductMappingDAO
    {
        public long MappingId { get; set; }
        public long ItemId { get; set; }
        public long? ItemGroupLevel1Id { get; set; }
        public long? ItemGroupLevel2Id { get; set; }
    }
}
