using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Dim_Warehouse
    {
        public long WarehouseId { get; set; }
        public string WhsCode { get; set; }
        public string Location { get; set; }
        public string WhsBranchName { get; set; }
        public string WarehouseLevel1Name { get; set; }
        public string WarehouseLevel2Name { get; set; }
    }
}
