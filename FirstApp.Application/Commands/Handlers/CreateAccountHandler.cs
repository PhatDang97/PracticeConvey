using Convey.CQRS.Commands;
using FirstApp.Application.Commands;

namespace FirstApp.Application.Commands.Handlers
{
    public class CreateAccountHandler : ICommandHandler<CreateAccount>
    {
        public Task HandleAsync(CreateAccount command, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
