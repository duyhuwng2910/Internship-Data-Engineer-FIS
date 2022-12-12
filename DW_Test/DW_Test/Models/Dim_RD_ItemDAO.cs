using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Dim_RD_ItemDAO
    {
        public long ItemId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Quality { get; set; }
        public string Performance { get; set; }
        public string LightColor { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
