using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class NCTT_Raw_NewItemDAO
    {
        public long Id { get; set; }
        public long? Month { get; set; }
        public long? Year { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
    }
}
