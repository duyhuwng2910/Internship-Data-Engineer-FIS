using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_AppUserDAO
    {
        public Dim_AppUserDAO()
        {
            AppUserRoleMappings = new HashSet<AppUserRoleMappingDAO>();
        }

        public long AppUserId { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public long SexId { get; set; }
        public DateTime? Birthday { get; set; }
        public string Avatar { get; set; }
        public string Department { get; set; }
        public long OrganizationId { get; set; }
        public long StatusId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public Guid RowId { get; set; }

        public virtual ICollection<AppUserRoleMappingDAO> AppUserRoleMappings { get; set; }
    }
}
