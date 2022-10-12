using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_WarehouseDAO
    {
        public long WarehouseId { get; set; }
        public string WhsCode { get; set; }
        public string Location { get; set; }
        public string WhsBranchName { get; set; }
        public string WarehouseLevel1Name { get; set; }
        public string WarehouseLevel2Name { get; set; }
    }
}
