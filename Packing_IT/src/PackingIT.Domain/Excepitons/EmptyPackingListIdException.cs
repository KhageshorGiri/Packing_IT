using PackingIT.Shared.Abstraction.Exceptions;

namespace PackingIT.Domain.Excepitons;
public class EmptyPackingListIdException : PackingITException
{
    public EmptyPackingListIdException() : base("Packing List ID cannot be empty.") { }
}
