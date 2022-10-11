using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Raw_Customer_Temp
    {
        public long Id { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CountyCode { get; set; }
        public string CountyName { get; set; }
        public string SaleBranch { get; set; }
        public string SaleChannel { get; set; }
        public string SaleRoom { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public long CustomerSourceId { get; set; }
    }
}
