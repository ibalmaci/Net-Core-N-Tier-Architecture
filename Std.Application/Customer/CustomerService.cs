using Std.Core;
using Std.Data.Domain;
using Std.Shared.Dto;

namespace Std.Application
{
    public class CustomerService : BaseAppService<CustomerDto, Customer>, ICustomerService
    {
        public ICashFlowService _cashFlowService;

        public CustomerService(
            IRepository<Customer, int> repository,
            ICashFlowService cashFlowService
        ) : base(repository)
        {
            _cashFlowService = cashFlowService;
        }

        public decimal GetBalance(int customerId)
        {
            return _cashFlowService.CalculateCustomerBalance(customerId);
        }

    }
}
