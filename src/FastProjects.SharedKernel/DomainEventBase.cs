using MediatR;

namespace FastProjects.SharedKernel;

/// <summary>
/// Base class for domain events.
/// Implements the INotification interface from MediatR.
/// </summary>
public abstract class DomainEventBase : INotification
{
    /// <summary>
    /// The date and time when the event occurred.
    /// </summary>
    public DateTime DateOccurred { get; init; } = DateTime.UtcNow;
}
