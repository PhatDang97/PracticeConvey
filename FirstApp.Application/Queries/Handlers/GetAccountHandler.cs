using Convey.CQRS.Queries;
using FirstApp.Application.DTO;

namespace FirstApp.Application.Queries.Handlers
{
    public class GetAccountHandler : IQueryHandler<GetAccount, AccountDto>
    {
        public Task<AccountDto> HandleAsync(GetAccount query, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
