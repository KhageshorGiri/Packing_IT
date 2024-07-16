
namespace PackingIT.Shared.Abstraction.Exceptions;

public abstract class PackingITException : Exception
{
    protected PackingITException(string message) : base(message) { }
}
