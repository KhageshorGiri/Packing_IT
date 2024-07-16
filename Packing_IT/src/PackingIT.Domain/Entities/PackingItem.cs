using PackingIT.Domain.ValueObjects;

namespace PackingIT.Domain.Entities;

public  class PackingItem
{
    public Guid Id { get; set; }

    private PackingItem _name;
    private Localization _localization;


    public readonly LinkedList<PackingItem> _items = new();

    public void AddItem(PackingItem item)
    {
        _items.AddLast(item);
    }
}
