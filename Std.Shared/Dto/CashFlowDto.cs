using System;
using System.Collections.Generic;
using System.Text;
using Std.Core;
using Std.Core.Enums;
using Std.Data.Domain;

namespace Std.Shared.Dto
{
    [AutoMap(typeof(CashFlow))]
    public class CashFlowDto : BaseDto
    {
        public int CustomerId { get; set; }
        public FlowType Type { get; set; }
        public decimal Amount { get; set; }

        public virtual CustomerDto Customer { get; set; }
    }
}
