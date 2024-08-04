using PackingIT.Domain.Events;
using PackingIT.Domain.Excepitons;
using PackingIT.Domain.ValueObjects;
using PackingIT.Shared.Abstraction.Domain;
using System.ComponentModel;

namespace PackingIT.Domain.Entities;

public  class PackingList : AggregateRoot<PackingListId>
{
    public PackingListId Id { get; set; }

    private PackingListName _name;
    private Localization _localization;


    public readonly LinkedList<PackingItem> _items = new();

    private PackingList(PackingListId id, PackingListName name, Localization localization)
    {
        Id = id;
        _name = name;
        _localization = localization;
    }


    public void AddItem(PackingItem item)
    {
        var alreadyExists = _items.Any(itm => itm.Name == item.Name);

        if (alreadyExists)
            throw new PackingItemAlreadyExistsException(_name, item.Name);

        _items.AddLast(item);

        AddEvent(new PackingItemAdded(this, item));
    }

    public void AddItems(IEnumerable<PackingItem> items)
    {
        foreach (var item in items)
        {
            AddItem(item);
        }
    }

    public void PackingItem(string itemName)
    {
        var item = GetItem(itemName);
        var packedItem = item with { IsPacked = true };

        _items.Find(item).Value = packedItem;
        AddEvent(new PackingItemPacked(this, packedItem));
    }

    public void RemoveItem(string itemName)
    {
        var item = GetItem(itemName);
        _items.Remove(item);
        AddEvent(new PackingItemRemoved(this, item));
    }

    private PackingItem GetItem(string itemName)
    {
        var item = _items.SingleOrDefault(i => i.Name == itemName);
        if (item is null)
            throw new PackingItemNotFoundException(itemName);
        return item;
    }
}
