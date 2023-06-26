using Convey.CQRS.Commands;

namespace FirstApp.Application.Commands
{
    public class CreateAccount : ICommand
    {
        public Guid Id { get; }
        public string Email { get; }
        public string Password { get; }

        public CreateAccount(Guid id, string email, string password)
        {
            Id = id;
            Email = email;
            Password = password;
        }
    }
}