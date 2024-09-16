using MediatR;

namespace FastProjects.SharedKernel;

public interface IDomainEventHandler<in TDomainEvent>
    : INotificationHandler<TDomainEvent>
    where TDomainEvent : DomainEventBase;
