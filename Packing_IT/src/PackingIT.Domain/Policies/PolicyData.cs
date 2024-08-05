
using PackingIT.Domain.ValueObjects;

namespace PackingIT.Domain.Policies;

public record PolicyData(TravelDays Days, Enums.Gender Gender, 
    ValueObjects.Temperature Temperature, Localization Localization);

