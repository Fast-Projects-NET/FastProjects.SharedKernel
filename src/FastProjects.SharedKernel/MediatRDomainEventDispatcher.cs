using MediatR;

namespace FastProjects.SharedKernel;

/// <summary>
/// Implementation of <see cref="IDomainEventDispatcher"/> using MediatR.
/// </summary>
/// <param name="mediator">The mediator instance used to publish domain events.</param>
public class MediatRDomainEventDispatcher(IMediator mediator) : IDomainEventDispatcher
{
    /// <inheritdoc />
    public async Task DispatchAndClearEvents(IEnumerable<EntityBase> entitiesWithEvents)
    {
        foreach (EntityBase entity in entitiesWithEvents)
        {
            DomainEventBase[] events = entity.DomainEvents.ToArray();
            entity.ClearDomainEvents();
            foreach (DomainEventBase domainEvent in events)
            {
                await mediator.Publish(domainEvent).ConfigureAwait(false);
            }
        }
    }

    /// <inheritdoc />
    public async Task DispatchAndClearEvents<TId>(IEnumerable<EntityBase<TId>> entitiesWithEvents)
        where TId : struct, IEquatable<TId>
    {
        foreach (EntityBase<TId> entity in entitiesWithEvents)
        {
            DomainEventBase[] events = entity.DomainEvents.ToArray();
            entity.ClearDomainEvents();
            foreach (DomainEventBase domainEvent in events)
            {
                await mediator.Publish(domainEvent).ConfigureAwait(false);
            }
        }
    }
}
