using Convey.WebApi.Requests;

namespace FirstApp.Application.Reqest.Handlers
{
    public class DeleteAccountHandler : IRequestHandler<DeleteAccount, int>
    {
        public async Task<int> HandleAsync(DeleteAccount request, CancellationToken cancellationToken = default)
        {
            return request.AccountlId;
        }
    }
}