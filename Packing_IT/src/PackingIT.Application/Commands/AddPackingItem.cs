using PackingIT.Shared.Abstraction.Commands;

namespace PackingIT.Application.Commands;

public record AddPackingItem(Guid PackingListId, string Name, decimal Quantity) : ICommand;
