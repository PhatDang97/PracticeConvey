using Convey.WebApi.Requests;

namespace FirstApp.Application.Reqest
{
    public class DeleteAccount : IRequest
    {
        public int AccountlId { get; }

        public DeleteAccount(int accountId)
        {
            AccountlId = accountId;
        }
    }
}
