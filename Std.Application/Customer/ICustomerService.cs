using Std.Core;
using Std.Shared.Dto;

namespace Std.Application
{
    public interface ICustomerService : IAppService<CustomerDto>, IService
    {
        decimal GetBalance(int customerId);
    }
}
