using PackingIT.Shared.Abstraction.Exceptions;

namespace PackingIT.Domain.Excepitons;
public class EmptyPackingListNameException : PackingITException
{
    public EmptyPackingListNameException() : base("Packing Item Name Cannot be Empty.") { }
}
