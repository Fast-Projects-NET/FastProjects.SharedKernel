using System.ComponentModel.DataAnnotations.Schema;

namespace FastProjects.SharedKernel;

/// <summary>
/// Abstract base class that supports domain events.
/// </summary>
public abstract class HasDomainEventsBase
{
    /// <summary>
    /// List of domain events associated with the entity.
    /// </summary>
    private readonly List<DomainEventBase> _domainEvents = [];

    /// <summary>
    /// Gets the domain events as a read-only collection.
    /// </summary>
    [NotMapped]
    public IEnumerable<DomainEventBase> DomainEvents =>
        _domainEvents.AsReadOnly();

    /// <summary>
    /// Registers a new domain event.
    /// </summary>
    /// <param name="domainEvent">The domain event to register.</param>
    protected void RegisterDomainEvent(DomainEventBase domainEvent) =>
        _domainEvents.Add(domainEvent);

    /// <summary>
    /// Clears all domain events.
    /// </summary>
    public void ClearDomainEvents() =>
        _domainEvents.Clear();
}
