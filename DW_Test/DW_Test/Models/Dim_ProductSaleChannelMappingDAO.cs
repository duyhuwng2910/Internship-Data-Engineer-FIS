using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Dim_ProductSaleChannelMappingDAO
    {
        public long MappingId { get; set; }
        public long? ItemGroupLevel1Id { get; set; }
        public long? SaleChannelId { get; set; }
    }
}
