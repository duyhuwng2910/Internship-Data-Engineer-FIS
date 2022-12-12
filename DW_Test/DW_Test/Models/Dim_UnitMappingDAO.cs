using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Dim_UnitMappingDAO
    {
        public long Unit_MappingId { get; set; }
        public long? CountryId { get; set; }
        public long? CountyId { get; set; }
        public long? CustomerId { get; set; }
        public long? SaleBranchId { get; set; }
        public long? SaleChannelId { get; set; }
        public long? SaleRoomId { get; set; }
        public string dem { get; set; }
    }
}
