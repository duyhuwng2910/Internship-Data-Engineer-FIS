using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_StoreMappingDAO
    {
        public long MappingId { get; set; }
        public long? ProvinceId { get; set; }
        public long? SaleBranchId { get; set; }
        public long? DistrictId { get; set; }
        public long? LevelId { get; set; }
        public long? CustomerId { get; set; }
        public long? SaleRoomId { get; set; }
    }
}
