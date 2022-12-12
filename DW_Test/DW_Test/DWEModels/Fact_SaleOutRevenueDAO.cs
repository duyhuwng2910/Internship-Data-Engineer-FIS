using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_SaleOutRevenueDAO
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public long ItemId { get; set; }
        public decimal? Revenue { get; set; }
        public long DateKey { get; set; }
        public long? ProductGroupingId { get; set; }
        public long? SaleTeamId { get; set; }
        public long? OrganizationProductId { get; set; }
        public long TransactionId { get; set; }
    }
}
