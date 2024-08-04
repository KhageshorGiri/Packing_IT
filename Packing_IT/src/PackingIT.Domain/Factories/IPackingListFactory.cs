using PackingIT.Domain.Entities;
using PackingIT.Domain.Enums;
using PackingIT.Domain.ValueObjects;

namespace PackingIT.Domain.Factories;

public interface IPackingListFactory
{
    PackingList Create(PackingListId id, PackingListName name, Localization localization);

    PackingList CreateWithDefaultItem(PackingListId id, PackingListName name, TravelDays days, Gender gender,
            Temperature temperature, Localization localization);
}
