using PackingIT.Shared.Abstraction.Exceptions;

namespace PackingIT.Application.Exceptions;

public class PackingListNotFoundException : PackingITException
{
    public Guid Id { get; }
    public PackingListNotFoundException(Guid id) : base($"Packing list with ID '{id}' was not found.")
        => Id = id;
}
