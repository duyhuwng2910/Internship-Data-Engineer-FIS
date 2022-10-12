using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_Employee_Year_PlanDAO
    {
        public long Id { get; set; }
        public long? EmployeeId { get; set; }
        public long? Year { get; set; }
        public decimal? RevenuePlan { get; set; }
    }
}
