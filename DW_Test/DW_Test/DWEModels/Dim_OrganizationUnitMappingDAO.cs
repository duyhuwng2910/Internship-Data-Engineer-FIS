using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_OrganizationUnitMappingDAO
    {
        public long Id { get; set; }
        public long SaleTeamId { get; set; }
        public long SaleBranchId { get; set; }
        public long SaleRoomId { get; set; }
    }
}
