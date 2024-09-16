namespace FastProjects.SharedKernel;

/// <summary>
/// Interface for dispatching domain events.
/// </summary>
public interface IDomainEventDispatcher
{
    /// <summary>
    /// Dispatches and clears domain events for the given entities.
    /// </summary>
    /// <param name="entitiesWithEvents">The entities with domain events to dispatch and clear.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task DispatchAndClearEvents(IEnumerable<EntityBase> entitiesWithEvents);

    /// <summary>
    /// Dispatches and clears domain events for the given entities with a specific identifier type.
    /// </summary>
    /// <typeparam name="TId">The type of the identifier.</typeparam>
    /// <param name="entitiesWithEvents">The entities with domain events to dispatch and clear.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task DispatchAndClearEvents<TId>(IEnumerable<EntityBase<TId>> entitiesWithEvents) where TId : struct, IEquatable<TId>;
}
