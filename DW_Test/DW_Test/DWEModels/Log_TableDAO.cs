﻿using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Log_TableDAO
    {
        public long Id { get; set; }
        public string TableName { get; set; }
        public long? LocalLength { get; set; }
        public string TimeGetLocal { get; set; }
        public long? RemoteLength { get; set; }
        public string TimeGetRemote { get; set; }
        public string TimeDAOtoEntityLocal { get; set; }
        public string TimeDAOtoEntityRemote { get; set; }
        public string TimeToRunSplit { get; set; }
        public long? Add { get; set; }
        public long? Update { get; set; }
        public long? Delete { get; set; }
        public string TimeToInsert { get; set; }
        public string TimeToUpdate { get; set; }
        public string TimeToDelete { get; set; }
        public string Duration { get; set; }
        public string Source { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
