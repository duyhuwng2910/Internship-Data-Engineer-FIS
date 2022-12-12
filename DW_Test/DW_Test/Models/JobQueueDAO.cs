using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class JobQueueDAO
    {
        public long Id { get; set; }
        public long JobId { get; set; }
        public string Queue { get; set; }
        public DateTime? FetchedAt { get; set; }
    }
}
