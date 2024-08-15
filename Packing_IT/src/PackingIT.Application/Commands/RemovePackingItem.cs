using PackingIT.Shared.Abstraction.Commands;

namespace PackingIT.Application.Commands;

public record RemovePackingItem(Guid PackinglistId, string Name) : ICommand;
