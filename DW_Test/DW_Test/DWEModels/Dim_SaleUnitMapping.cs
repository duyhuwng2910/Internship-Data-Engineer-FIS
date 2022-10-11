using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Dim_SaleUnitMapping
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
