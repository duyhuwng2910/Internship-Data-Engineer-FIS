﻿using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class KPI_Fact_SaleOutStoreCount_PlanDAO
    {
        public long Id { get; set; }
        public long? MonthKey { get; set; }
        public long? EmployeeId { get; set; }
        public long? KPIId { get; set; }
        public long? Plan { get; set; }
    }
}
