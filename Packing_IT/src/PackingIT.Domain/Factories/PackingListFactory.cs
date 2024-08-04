using PackingIT.Domain.Entities;
using PackingIT.Domain.Enums;
using PackingIT.Domain.ValueObjects;

namespace PackingIT.Domain.Factories
{
    public class PackingListFactory : IPackingListFactory
    {
        public PackingList Create(PackingListId id, PackingListName name, Localization localization)
        {
            throw new NotImplementedException();
        }

        public PackingList CreateWithDefaultItem(PackingListId id, PackingListName name, TravelDays days, Gender gender, 
            Temperature temperature, Localization localization)
        {
            throw new NotImplementedException();
        }
    }
}
