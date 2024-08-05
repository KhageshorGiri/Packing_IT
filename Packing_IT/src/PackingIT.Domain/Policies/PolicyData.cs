
using PackingIT.Domain.Enums;
using PackingIT.Domain.ValueObjects;

namespace PackingIT.Domain.Policies;

public record PolicyData(TravelDays Days, Gender Gender, Temperature Temperature, Localization Localization);

