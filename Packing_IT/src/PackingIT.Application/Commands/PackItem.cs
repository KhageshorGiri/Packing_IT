using PackingIT.Shared.Abstraction.Commands;

namespace PackingIT.Application.Commands;

public record PackItem(Guid PackingListId, string Name) : ICommand;
