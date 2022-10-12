using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_OrganizationUnitDAO
    {
        public long OrganizationId { get; set; }
        public string OrganizationCode { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationGroupingLvl1 { get; set; }
        public string OrganizationGroupingLvl2 { get; set; }
    }
}
