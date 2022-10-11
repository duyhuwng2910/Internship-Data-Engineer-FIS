using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class KPI_Raw_SaleEmployeeMapping
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
