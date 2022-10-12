using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Raw_SalePlan_RevenueDAO
    {
        public long Id { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string CustomerCode { get; set; }
        public string Customer { get; set; }
        public decimal? YearPlan { get; set; }
        public decimal? Q01Plan { get; set; }
        public decimal? Q02Plan { get; set; }
        public decimal? Q03Plan { get; set; }
        public decimal? Q04Plan { get; set; }
        public decimal? M01Plan { get; set; }
        public decimal? M02Plan { get; set; }
        public decimal? M03Plan { get; set; }
        public decimal? M04Plan { get; set; }
        public decimal? M05Plan { get; set; }
        public decimal? M06Plan { get; set; }
        public decimal? M07Plan { get; set; }
        public decimal? M08Plan { get; set; }
        public decimal? M09Plan { get; set; }
        public decimal? M10Plan { get; set; }
        public decimal? M11Plan { get; set; }
        public decimal? M12Plan { get; set; }
        public long? Year { get; set; }
    }
}
