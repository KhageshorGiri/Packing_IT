using PackingIT.Application.Exceptions;
using PackingIT.Domain.Repositories;
using PackingIT.Shared.Abstraction.Commands;

namespace PackingIT.Application.Commands.Handlers;

public class RemovePackingListHandler : ICommandHandler<RemovePackingList>
{
    private readonly IPackingListRepository _repository;
    public RemovePackingListHandler(IPackingListRepository repository)
    {
        this._repository = repository;
    }

    public async Task HandleAsync(RemovePackingList command)
    {
        var packingList = await _repository.GetAsync(command.Id);

        if(packingList is null)
            throw new PackingListNotFoundException(command.Id);

        await _repository.DeleteAsync(packingList);
    }
}
