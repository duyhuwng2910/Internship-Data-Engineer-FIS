using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Fact_KPI_IndirectSalesOrder
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public long BuyerStoreId { get; set; }
        public long EmployeeId { get; set; }
        public long StoreTypeId { get; set; }
        public long OrderDateKey { get; set; }
        public long SaleTeamId { get; set; }
        public long IndirectSalesOrderId { get; set; }
        public decimal Total { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
