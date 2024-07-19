
using PackingIT.Domain.Excepitons;

namespace PackingIT.Domain.ValueObjects;


public record PackingListName
{
    public string Value { get; }

    public PackingListName(string value)
    {
        if(string.IsNullOrWhiteSpace(value))
            throw new EmptyPackingListNameException();
        Value = value;
    }

    public static implicit operator PackingListName(string name) => new PackingListName(name);

    public static implicit operator string(PackingListName name) => name.Value;
}
