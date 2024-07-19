using PackingIT.Domain.Entities;
using PackingIT.Domain.ValueObjects;
using PackingIT.Shared.Abstraction.Domain;

namespace PackingIT.Domain.Events;

public record PackingItemRemoved(PackingList PackingList, PackingItem PackingItem) : IDomainEvent;
