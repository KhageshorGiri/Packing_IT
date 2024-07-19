using PackingIT.Shared.Abstraction.Exceptions;

namespace PackingIT.Domain.Excepitons;

public class PackingItemNotFoundException : PackingITException
{
    public string ItemName { get; }

    public PackingItemNotFoundException(string itemName) : base($"Packing item '{itemName}' was not found.")
        => ItemName = itemName;
}
