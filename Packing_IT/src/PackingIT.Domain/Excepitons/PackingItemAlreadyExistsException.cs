using PackingIT.Shared.Abstraction.Exceptions;

namespace PackingIT.Domain.Excepitons;

public class PackingItemAlreadyExistsException : PackingITException
{
    public string ListName { get; }
    public string ItemName { get; }
    public PackingItemAlreadyExistsException(string listName, string itemName)
       : base($"Packing list: '{listName}' already defined item '{itemName}'")
    {
        ListName = listName;
        ItemName = itemName;
    }
}
