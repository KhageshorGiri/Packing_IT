using PackingIT.Domain.Entities;
using PackingIT.Domain.ValueObjects;

namespace PackingIT.Domain.Repositories;

public interface IPackingListRepository
{
    Task<PackingList> GetAsync(PackingListId id);
    Task AddAsync(PackingList packingList);
    Task UpdateAsync(PackingList packingList);
    Task DeleteAsync(PackingList packingList);
}
