using Std.Core;
using Std.Shared.Dto;

namespace Std.Application
{
    public interface ICashFlowService : IAppService<CashFlowDto>, IService
    {
        decimal CalculateCustomerBalance(int customerId);
    }
}
