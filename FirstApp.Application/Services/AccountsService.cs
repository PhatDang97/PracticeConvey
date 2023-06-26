using Convey.CQRS.Commands;
using Convey.CQRS.Events;
using Convey.CQRS.Queries;
using FirstApp.Application.Commands;
using FirstApp.Application.DTO;
using FirstApp.Application.Events;
using FirstApp.Application.Queries;

namespace FirstApp.Application.Services
{
    public class AccountsService
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IEventDispatcher _eventDispatcher;

        public AccountsService(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher, IEventDispatcher eventDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
            _eventDispatcher = eventDispatcher;
        }

        public async Task CreateAccountAsync(CreateAccount command)
        {
            await _commandDispatcher.SendAsync(command);
        }

        public async Task<AccountDto> GetAccountAsync(int id)
        {
            var result = await _queryDispatcher.QueryAsync(new GetAccount { Id = id });
            return result;
        }

        public async Task PostProcessAccountCreation(AccountCreated @event)
        {
            await _eventDispatcher.PublishAsync(@event);
        }
    }
}
