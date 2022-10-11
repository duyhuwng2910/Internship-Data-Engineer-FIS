using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class KPI_Incur_Revenue
    {
        public long? Revenue { get; set; }
        public long? SaleRoomId { get; set; }
        public long? SaleBranchId { get; set; }
        public long? DateKey { get; set; }
        public int KPITypeId { get; set; }
    }
}
