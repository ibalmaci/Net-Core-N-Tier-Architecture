using System.Linq;
using Std.Core;
using Std.Core.Enums;
using Std.Data.Domain;
using Std.Shared.Dto;

namespace Std.Application
{
    public class CashFlowService : BaseAppService<CashFlowDto, CashFlow>, ICashFlowService
    {
        public CashFlowService(IRepository<CashFlow, int> repository) : base(repository)
        {
        }

        public decimal CalculateCustomerBalance(int customerId)
        {
            var deposit = _repository.Where(c => c.Id == customerId && c.Type == FlowType.Deposit).Sum(c => c.Amount);
            var withdraw = _repository.Where(c => c.Id == customerId && c.Type == FlowType.Deposit).Sum(c => c.Amount);

            return deposit - withdraw;
        }
    }
}
