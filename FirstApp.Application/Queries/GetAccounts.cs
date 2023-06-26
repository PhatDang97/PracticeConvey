using Convey.CQRS.Queries;
using FirstApp.Application.DTO;

namespace FirstApp.Application.Queries
{
    public class GetAccounts : IQuery<IEnumerable<AccountDto>>           
    {
    }
}
