using PackingIT.Application.DTO;
using PackingIT.Shared.Abstraction.Queries;

namespace PackingIT.Application.Queries;

public class GetPackingListHandler : IQueryHandler<GetPackingList, PackingListDto>
{
    public Task<PackingListDto> HandleAsync(GetPackingList query)
    {
        throw new NotImplementedException();
    }
}
