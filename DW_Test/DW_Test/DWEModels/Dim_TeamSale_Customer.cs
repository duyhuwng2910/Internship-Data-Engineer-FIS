using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Dim_TeamSale_Customer
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public long OrganizationId { get; set; }
    }
}
