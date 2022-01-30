using System;
using System.Collections.Generic;

namespace Labb_3___School_Program.Models
{
    public partial class StudClass
    {
        public int StudClassId { get; set; }
        public int? FkStudId { get; set; }
        public int? FkClassId { get; set; }

        public virtual Class? FkClass { get; set; }
        public virtual Student? FkStud { get; set; }
    }
}
