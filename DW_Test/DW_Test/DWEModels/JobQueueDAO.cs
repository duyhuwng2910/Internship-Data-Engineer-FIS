using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class JobQueueDAO
    {
        public int Id { get; set; }
        public long JobId { get; set; }
        public string Queue { get; set; }
        public DateTime? FetchedAt { get; set; }
    }
}
