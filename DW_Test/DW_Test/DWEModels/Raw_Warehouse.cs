using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Raw_Warehouse
    {
        public long InventoryId { get; set; }
        public long? MA_KHO { get; set; }
        public string TEN_KHO_C2 { get; set; }
        public string TEN_KHO_C1 { get; set; }
    }
}
