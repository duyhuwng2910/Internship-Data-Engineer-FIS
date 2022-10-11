using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Fact_KPI_StoreChecking
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
