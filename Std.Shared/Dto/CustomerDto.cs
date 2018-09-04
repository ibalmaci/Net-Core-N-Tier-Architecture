using System;
using Std.Core;
using Std.Data.Domain;

namespace Std.Shared.Dto
{
    [AutoMap(typeof(Customer))]
    public class CustomerDto : BaseDto
    {
        public string Name { set; get; }
        public string Lastname { set; get; }
        public DateTime BirthDate { get; set; }
    }
}
