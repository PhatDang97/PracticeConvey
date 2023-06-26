using Convey.CQRS.Events;

namespace FirstApp.Application.Events.Handlers
{
    public class AccountCreatedHandler : IEventHandler<AccountCreated>
    {
        public Task HandleAsync(AccountCreated @event, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
