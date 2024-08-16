using PackingIT.Shared.Abstraction.Exceptions;

namespace PackingIT.Application.Exceptions;

public class PackingListAlreadyExistsException : PackingITException
{
    public string Name { get; }

    public PackingListAlreadyExistsException(string name)
        : base($"Packing list with name '{name}' already exists.")
    {
        Name = name;
    }
}
