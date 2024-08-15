using PackingIT.Application.Exceptions;
using PackingIT.Domain.Repositories;
using PackingIT.Domain.ValueObjects;
using PackingIT.Shared.Abstraction.Commands;

namespace PackingIT.Application.Commands.Handlers;

public class AddPackingItemHandler : ICommandHandler<AddPackingItem>
{
    private readonly IPackingListRepository _repository;
    public AddPackingItemHandler(IPackingListRepository packingListRepository)
    {
        _repository = packingListRepository;
    }

    public async Task HandleAsync(AddPackingItem command)
    {

        var packingList = await _repository.GetAsync(command.PackingListId);

        if (packingList is null)
            throw new PackingListNotFoundException(command.PackingListId);

        var packingListItem = new PackingItem(command.Name, command.Quantity);
        packingList.AddItem(packingListItem);

        await _repository.UpdateAsync(packingList);
    }
}
