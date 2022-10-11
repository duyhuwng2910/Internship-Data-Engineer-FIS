using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class test_path
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
