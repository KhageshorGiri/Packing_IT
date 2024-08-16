

using PackingIT.Application.DTO.External;
using PackingIT.Domain.ValueObjects;

namespace PackingIT.Application.Services;

public interface IWeatherService
{
    Task<WeatherDto> GetWeatherAsync(Localization localization);
}
