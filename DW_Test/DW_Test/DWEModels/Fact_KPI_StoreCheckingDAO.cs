using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_KPI_StoreCheckingDAO
    {
        public long Id { get; set; }
        public long StoreId { get; set; }
        public long EmployeeId { get; set; }
        public long StoreTypeId { get; set; }
        public long? ImageCounter { get; set; }
        public long DateKey { get; set; }
        public bool IsOpenedStore { get; set; }
        public long SaleTeamId { get; set; }
        public long StoreCheckingId { get; set; }
        public DateTime? CheckOutAt { get; set; }
    }
}
