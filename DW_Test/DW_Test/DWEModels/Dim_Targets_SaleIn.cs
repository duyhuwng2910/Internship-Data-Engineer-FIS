using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Dim_Targets_SaleIn
    {
        public long TargetSaleInId { get; set; }
        public string TargetCode { get; set; }
        public string TargetName { get; set; }
        public string TargetGroupingName { get; set; }
        public long? OrderNumber { get; set; }
    }
}
