using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class ServerDAO
    {
        public string Id { get; set; }
        public string Data { get; set; }
        public DateTime LastHeartbeat { get; set; }
    }
}
