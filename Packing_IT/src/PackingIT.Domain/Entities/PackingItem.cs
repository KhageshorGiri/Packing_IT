namespace PackingIT.Domain.Entities;

public  class PackingItem
{
    public Guid Id { get; set; }

    private string? _name;
    private string? _localization;


    public readonly LinkedList<PackingItem> _items = new();

    public void AddItem(PackingItem item)
    {
        _items.AddLast(item);
    }
}
