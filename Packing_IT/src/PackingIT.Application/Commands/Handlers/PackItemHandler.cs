using PackingIT.Application.Exceptions;
using PackingIT.Domain.Repositories;
using PackingIT.Shared.Abstraction.Commands;

namespace PackingIT.Application.Commands.Handlers;

public class PackItemHandler : ICommandHandler<PackItem>
{
    private readonly IPackingListRepository _repository;
    public PackItemHandler(IPackingListRepository packingListRepository)
    {
        _repository = packingListRepository;
    }

    public async Task HandleAsync(PackItem command)
    {
       /* var packingList = await _repository.GetAsync(command.PackingListId);

        if(packingList is null)
            throw new PackingListNotFoundException(command.PackingListId);

        packingList.AddItem(command.Name);

        await _repository.UpdateAsync(packingList);*/

        throw new NotImplementedException();
    }
}
