using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class KPI_Raw_SaleEmployeeMappingDAO
    {
        public long Id { get; set; }
        public string SaleEmployeeCode { get; set; }
        public string SaleEmployeeName { get; set; }
        public string SaleRoom { get; set; }
        public string SaleChannel { get; set; }
        public string SaleBranch { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
    }
}
