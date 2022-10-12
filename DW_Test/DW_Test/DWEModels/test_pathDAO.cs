using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class test_pathDAO
    {
        public long ItemGroupLevelId { get; set; }
        public string ItemGroupLevelName { get; set; }
        public string ParentId { get; set; }
        public string Path { get; set; }
        public string Level1Name { get; set; }
        public string Level2Name { get; set; }
        public long? Measure { get; set; }
    }
}
