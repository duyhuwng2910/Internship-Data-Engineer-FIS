using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class KPI_Dim_SaleEmployeeMappingDAO
    {
        public long Id { get; set; }
        public long SaleEmployeeId { get; set; }
        public long? SaleRoomId { get; set; }
        public long? SaleChannelId { get; set; }
        public long? SaleBranchId { get; set; }
        public long? CountyId { get; set; }
        public long? CountryId { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime? EndAt { get; set; }
    }
}
