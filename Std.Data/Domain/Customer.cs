using Std.Core;
using System;

namespace Std.Data.Domain
{
    public class Customer : BaseEntity
    {
        public string Name { set; get; }
        public string Lastname { set; get; }
        public DateTime BirthDate { get; set; }
    }
}
