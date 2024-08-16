using PackingIT.Application.DTO;
using PackingIT.Shared.Abstraction.Queries;

namespace PackingIT.Application.Queries;

public class GetPackingList  : IQuery<PackingListDto>
{
    public Guid Id { get; set; }
}
