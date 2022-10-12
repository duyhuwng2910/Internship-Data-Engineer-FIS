using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class TMDT_Dim_CustomerDAO
    {
        public long CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }
    }
}
