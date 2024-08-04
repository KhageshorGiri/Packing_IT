using PackingIT.Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingIT.Domain.Excepitons;

public class InvalidTravelDaysException : PackingITException
{
    public ushort Days { get; set; }

    public InvalidTravelDaysException(ushort days)
        : base($"Value '{days}' is invalid travel days.")
        => Days = days;
}
