using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Raw_Customer_RepDAO
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
    }
}
