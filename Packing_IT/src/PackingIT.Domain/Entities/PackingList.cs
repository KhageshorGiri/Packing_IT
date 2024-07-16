using PackingIT.Domain.ValueObjects;

namespace PackingIT.Domain.Entities;

public  class PackingList
{
    public Guid Id { get; set; }

    private PackingList _name;
    private Localization _localization;


    public readonly LinkedList<PackingList> _items = new();

    public void AddItem(PackingList item)
    {
        _items.AddLast(item);
    }
}
