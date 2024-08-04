using PackingIT.Shared.Abstraction.Exceptions;

namespace PackingIT.Domain.Excepitons;

public class InvalidTemperatureException : PackingITException
{
    public double Temperature { get; set; }
    public InvalidTemperatureException(double temprature) 
        : base($"Value '{temprature}' is invalid temperature.")
    => Temperature = temprature;
}
