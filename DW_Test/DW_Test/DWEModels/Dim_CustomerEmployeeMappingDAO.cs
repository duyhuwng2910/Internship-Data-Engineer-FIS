using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_CustomerEmployeeMappingDAO
    {
        public long MappingId { get; set; }
        public long CustomerId { get; set; }
        public long? EmployeeId { get; set; }
    }
}
