using Convey.CQRS.Queries;
using FirstApp.Application.DTO;

namespace FirstApp.Application.Queries.Handlers
{
    public class GetAccountsHandler : IQueryHandler<GetAccounts, IEnumerable<AccountDto>>
    {
        public Task<IEnumerable<AccountDto>> HandleAsync(GetAccounts query, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
