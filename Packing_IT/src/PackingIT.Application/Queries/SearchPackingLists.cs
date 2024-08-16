using PackingIT.Application.DTO;
using PackingIT.Shared.Abstraction.Queries;

namespace PackingIT.Application.Queries;

public class SearchPackingLists : IQuery<IEnumerable<PackingListDto>>
{
    public string SearchPhrase { get; set; }
}