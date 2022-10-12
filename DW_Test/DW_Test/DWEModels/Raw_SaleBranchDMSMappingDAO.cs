using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Raw_SaleBranchDMSMappingDAO
    {
        public long Id { get; set; }
        public long? SaleBranchId { get; set; }
        public string SaleBranchName { get; set; }
        public long? SaleRoomId { get; set; }
        public string SaleRoomName { get; set; }
        public long? DMS_OrganizationId { get; set; }
        public string DMS_Name { get; set; }
    }
}
