using PackingIT.Domain.Excepitons;
using PackingIT.Domain.ValueObjects;
using PackingIT.Shared.Abstraction.Domain;
using System.ComponentModel;

namespace PackingIT.Domain.Entities;

public  class PackingList : AggregateRoot<PackingListId>
{
    public PackingListId Id { get; set; }

    private PackingItemName _name;
    private Localization _localization;


    public readonly LinkedList<PackingItem> _items = new();

    public void AddItem(PackingItem item)
    {
        var exectedItem = _items.Any(itm => itm.Name == item.Name);

        if (exectedItem)
            throw new PackingItemAlreadyExistsException(_name, item.Name);

        _items.AddLast(item);

        AddingNewEventArgs()
    }
}
