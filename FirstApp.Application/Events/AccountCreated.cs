using Convey.CQRS.Events;

namespace FirstApp.Application.Events
{
    public class AccountCreated : IEvent
    {
        public int Id { get; }

        public AccountCreated(int id)
        {
            Id = id;
        }
    }
}