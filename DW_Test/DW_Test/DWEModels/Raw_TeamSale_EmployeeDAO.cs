using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Raw_TeamSale_EmployeeDAO
    {
        public long Id { get; set; }
        public string MA_NV { get; set; }
        public string TEN_NV { get; set; }
        public string TEN_DOI { get; set; }
        public DateTime START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
    }
}
