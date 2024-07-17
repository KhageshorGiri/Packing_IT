using PackingIT.Shared.Abstraction.Exceptions;

namespace PackingIT.Domain.Excepitons;

public class EmptyPackingListItemNameException : PackingITException
{
    public EmptyPackingListItemNameException() : base("Packing item can not be empty.") { }
}
