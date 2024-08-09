

namespace PackingIT.Shared.Abstraction.Commands;

public interface ICommandDispatcher
{
    Task DispatchAsync<Tcommand>(Tcommand command) where Tcommand : class, ICommand; 
}
