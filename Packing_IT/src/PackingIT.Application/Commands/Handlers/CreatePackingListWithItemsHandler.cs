using PackingIT.Application.DTO.External;
using PackingIT.Application.Exceptions;
using PackingIT.Application.Services;
using PackingIT.Domain.Factories;
using PackingIT.Domain.Repositories;
using PackingIT.Domain.ValueObjects;
using PackingIT.Shared.Abstraction.Commands;

namespace PackingIT.Application.Commands.Handlers;

public class CreatePackingListWithItemsHandler : ICommandHandler<CreatePackingListWithItems>
{
    private readonly IPackingListRepository _repository;
    private readonly IPackingListFactory _factory;
    private readonly IPackingListReadService _readService;
    private readonly IWeatherService _weatherService;

    public CreatePackingListWithItemsHandler(IPackingListRepository repository, IPackingListFactory factory,
        IPackingListReadService readService, IWeatherService weatherService)
    {
        _repository = repository;
        _factory = factory;
        _readService = readService;
        _weatherService = weatherService;
    }

    public async Task HandleAsync(CreatePackingListWithItems command)
    {
        var (id, name, days, gender, localizationWriteModel) = command;

        if (await _readService.ExistByNameAsync(name))
            throw new PackingListAlreadyExistsException(name);

        var localization = new Localization(localizationWriteModel.City, localizationWriteModel.Country);
        var weather = await _weatherService.GetWeatherAsync(localization);

        if (weather is null)
            throw new MissingLocalizationWeatherException(localization);

        var packingList = _factory.CreateWithDefaultItem(id, name, days, gender, weather.Temprateure,
              localization);

        await _repository.AddAsync(packingList);
    }
}
