using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_SaleUnitMappingDAO
    {
        public long MappingId { get; set; }
        public long? CustomerId { get; set; }
        public long? CountyId { get; set; }
        public long? SaleBranchId { get; set; }
        public long? SaleChannelId { get; set; }
        public long? SaleRoomId { get; set; }
        public long? CountryId { get; set; }
        public long? DMS_StoreId { get; set; }
        public bool? IsKeyCustomer { get; set; }
    }
}
