using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_TeamSale_EmployeeDAO
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public long OrganizationId { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime? EndAt { get; set; }
    }
}
