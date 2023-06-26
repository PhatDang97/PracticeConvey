using Convey.CQRS.Queries;
using FirstApp.Application.DTO;

namespace FirstApp.Application.Queries
{
    public class GetAccount : IQuery<AccountDto>
    {
        public int Id { get; set; }
    }
}
