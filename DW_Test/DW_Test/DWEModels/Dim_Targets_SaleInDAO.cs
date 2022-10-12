using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_Targets_SaleInDAO
    {
        public long TargetSaleInId { get; set; }
        public string TargetCode { get; set; }
        public string TargetName { get; set; }
        public string TargetGroupingName { get; set; }
        public long? OrderNumber { get; set; }
    }
}
