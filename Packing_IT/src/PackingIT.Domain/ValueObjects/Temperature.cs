using PackingIT.Domain.Excepitons;

namespace PackingIT.Domain.ValueObjects;

public class Temperature
{
    public double Value { get; }

    public Temperature(double value)
    {
        if (value is < -100 or > 100)
            throw new InvalidTemperatureException(value);
        Value = value;
    }

    public static implicit operator Temperature(double temprature) => new Temperature(temprature);

    public static implicit operator double(Temperature temperature) => temperature.Value;
}
