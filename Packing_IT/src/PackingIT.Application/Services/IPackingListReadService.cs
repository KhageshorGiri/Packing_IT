namespace PackingIT.Application.Services;

public interface IPackingListReadService
{
    Task<bool> ExistByNameAsync(string name);
}
