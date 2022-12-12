using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_C4LED_SaleUnitMappingDAO
    {
        public long SaleUnitMappingId { get; set; }
        public string MappingName { get; set; }
        public long? SaleUnitId { get; set; }
        public long? SaleCenterId { get; set; }
        public long? SaleBranchId { get; set; }
    }
}
