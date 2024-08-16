using PackingIT.Domain.ValueObjects;
using PackingIT.Shared.Abstraction.Exceptions;

namespace PackingIT.Application.DTO.External;

public class MissingLocalizationWeatherException : PackingITException
{
    public Localization Localization { get; }

    public MissingLocalizationWeatherException(Localization localization)
        : base($"Couldn't fetch weather data for localization '{localization.Country}/{localization.City}'.")
    {
        Localization = localization;
    }
}
