using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Raw_Product_SalePlan
    {
        public long Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public string ERPGroup { get; set; }
        public string SPC1Group { get; set; }
        public string SPC2Group { get; set; }
        public string SPC3Group { get; set; }
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
