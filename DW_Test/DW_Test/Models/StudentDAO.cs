using System;
using System.Collections.Generic;

namespace DW_Test.Models
{
    public partial class StudentDAO
    {
        public long Id { get; set; }
        public string StudentID { get; set; }
        public string Name { get; set; }
        public long? Age { get; set; }
        public long? GPA { get; set; }
    }
}
