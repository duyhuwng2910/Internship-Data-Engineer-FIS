using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_SaleBranchDAO
    {
        public long SaleBranchId { get; set; }
        public string SaleBranchCode { get; set; }
        public string SaleBranchName { get; set; }
        public long? DMS_OrganizationId { get; set; }
        public string DMS_Name { get; set; }
    }
}
