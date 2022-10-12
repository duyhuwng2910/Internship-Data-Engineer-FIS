using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class PageDAO
    {
        public PageDAO()
        {
            ActionPageMappings = new HashSet<ActionPageMappingDAO>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public bool IsDeleted { get; set; }
        public long MenuId { get; set; }

        public virtual MenuDAO Menu { get; set; }
        public virtual ICollection<ActionPageMappingDAO> ActionPageMappings { get; set; }
    }
}
