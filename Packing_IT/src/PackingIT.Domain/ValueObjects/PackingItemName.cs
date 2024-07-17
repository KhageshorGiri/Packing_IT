
using PackingIT.Domain.Excepitons;

namespace PackingIT.Domain.ValueObjects;


public record PackingItemName
{
    public string Value { get; }

    public PackingItemName(string value)
    {
        if(string.IsNullOrWhiteSpace(value))
            throw new EmptyPackingListNameException();
        Value = value;
    }

    public static implicit operator PackingItemName(string name) => new PackingItemName(name);

    public static implicit operator string(PackingItemName name) => name.Value;
}
