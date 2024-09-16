namespace FastProjects.SharedKernel;

/// <summary>
/// Abstract base class for entities with a Guid identifier.
/// Inherits from HasDomainEventsBase to support domain events.
/// </summary>
public abstract class EntityBase : HasDomainEventsBase
{
    /// <summary>
    /// The unique identifier for the entity.
    /// </summary>
    public Guid Id { get; protected set; } = Guid.NewGuid();
}

/// <summary>
/// Abstract base class for entities with a generic identifier.
/// Inherits from HasDomainEventsBase to support domain events.
/// </summary>
/// <typeparam name="TId">The type of the identifier.</typeparam>
public abstract class EntityBase<TId> : HasDomainEventsBase
    where TId : struct, IEquatable<TId>
{
    /// <summary>
    /// The unique identifier for the entity.
    /// </summary>
    public TId Id { get; protected set; } = default!;
}
