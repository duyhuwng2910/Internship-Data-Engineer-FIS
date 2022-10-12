using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_ItemGroupLevelDAO
    {
        public long ItemGroupLevelId { get; set; }
        public string ItemGroupLevelName { get; set; }
        public long? ParentId { get; set; }
    }
}
