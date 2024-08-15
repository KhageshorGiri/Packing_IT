using PackingIT.Application.Exceptions;
using PackingIT.Domain.Repositories;
using PackingIT.Shared.Abstraction.Commands;

namespace PackingIT.Application.Commands.Handlers;

public class RemovePackingItemHandler : ICommandHandler<RemovePackingItem>
{
    private readonly IPackingListRepository _repository;
    public RemovePackingItemHandler(IPackingListRepository packingListRepository)
    {
        _repository = packingListRepository;   
    }
    public async Task HandleAsync(RemovePackingItem command)
    {
        var packingList = await _repository.GetAsync(command.PackingListId);

        if (packingList is null)
            throw new PackingListNotFoundException(command.PackingListId);

        packingList.RemoveItem(command.Name);

        await _repository.UpdateAsync(packingList);
    }
}
