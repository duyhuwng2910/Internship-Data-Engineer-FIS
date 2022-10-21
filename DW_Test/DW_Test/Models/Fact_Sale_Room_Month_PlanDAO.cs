﻿using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class Fact_Sale_Room_Month_PlanDAO
    {
        public long Id { get; set; }
        public long SaleRoomId { get; set; }
        public long MonthKey { get; set; }
        public long? Quantity { get; set; }
        public long? UnitPrice { get; set; }
        public decimal? Revenue { get; set; }
    }
}