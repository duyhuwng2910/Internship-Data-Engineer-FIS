using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_KPI_IndirectSalesOrderDAO
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
