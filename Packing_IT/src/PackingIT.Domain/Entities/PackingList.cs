using PackingIT.Domain.ValueObjects;
using PackingIT.Shared.Abstraction.Domain;

namespace PackingIT.Domain.Entities;

public  class PackingList : AggregateRoot<PackingListId>
{
    public PackingListId Id { get; set; }

    private PackingItemName _name;
    private Localization _localization;


    public readonly LinkedList<PackingList> _items = new();

    public void AddItem(PackingList item)
    {
        _items.AddLast(item);
    }
}
