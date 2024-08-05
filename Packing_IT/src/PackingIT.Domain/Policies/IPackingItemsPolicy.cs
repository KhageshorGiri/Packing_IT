using PackingIT.Domain.ValueObjects;

namespace PackingIT.Domain.Policies;

public interface IPackingItemsPolicy
{
    bool IsApplicable(PolicyData data);
    IEnumerable<PackingItem> GenerateItems(PolicyData data);
}
