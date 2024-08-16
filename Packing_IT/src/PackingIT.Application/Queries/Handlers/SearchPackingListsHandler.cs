using PackingIT.Application.DTO;
using PackingIT.Shared.Abstraction.Queries;

namespace PackingIT.Application.Queries.Handlers;

public class SearchPackingListsHandler : IQueryHandler<SearchPackingLists, IEnumerable<PackingListDto>>
{
    public Task<IEnumerable<PackingListDto>> HandleAsync(SearchPackingLists query)
    {
        throw new NotImplementedException();
    }
}
