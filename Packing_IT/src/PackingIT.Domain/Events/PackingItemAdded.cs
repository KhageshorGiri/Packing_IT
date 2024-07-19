using PackingIT.Domain.Entities;
using PackingIT.Domain.ValueObjects;
using PackingIT.Shared.Abstraction.Domain;

namespace PackingIT.Domain.Events;

public record PackingItemAdded(PackingList packingList, PackingItem packingItem) : IDomainEvent;

