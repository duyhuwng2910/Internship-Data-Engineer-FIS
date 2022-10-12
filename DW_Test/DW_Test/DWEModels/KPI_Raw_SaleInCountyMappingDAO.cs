using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class KPI_Raw_SaleInCountyMappingDAO
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
