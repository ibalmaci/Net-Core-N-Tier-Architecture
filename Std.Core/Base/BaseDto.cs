using System;
using System.Collections.Generic;
using System.Text;

namespace Std.Core
{
    public class BaseDto : IEntityDto<int>
    {
        public int Id { get; set; }
    }
}
