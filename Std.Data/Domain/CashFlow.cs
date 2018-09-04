using Std.Core;
using Std.Core.Enums;

namespace Std.Data.Domain
{
    public class CashFlow : BaseEntity
    {
        public int CustomerId { get; set; }
        public FlowType Type { get; set; }
        public decimal Amount { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
