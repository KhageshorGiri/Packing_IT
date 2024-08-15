using PackingIT.Shared.Abstraction.Commands;

namespace PackingIT.Application.Commands;

public record RemovePackingList(Guid Id) : ICommand;

