﻿using FluentAssertions;
using MediatR;
using NSubstitute;

namespace FastProjects.SharedKernel.UnitTests.MediatRDomainEventDispatcherTests;

public class MediatRDomainEventDispatcherWithGuid_DispatchAndClearEvents
{
    private readonly IMediator _mediator = Substitute.For<IMediator>();
    
    private class TestDomainEvent : DomainEventBase
    {
    }
    
    private class TestEntity : EntityBase<Guid>
    {
        public TestEntity() { Id = Guid.NewGuid(); }
        public void CallRegisterDomainEvents() => RegisterDomainEvent(new TestDomainEvent());
    }
    
    [Fact]
    public async Task DispatchAndClearEvents_Should_DispatchEvents()
    {
        // Arrange
        var entity = new TestEntity();
        entity.CallRegisterDomainEvents();
        entity.CallRegisterDomainEvents();
        const int expectedCallCount = 2;
        var entitiesWithEvents = new List<EntityBase<Guid>> { entity };
        
        var dispatcher = new MediatRDomainEventDispatcher(_mediator);
        
        // Act
        await dispatcher.DispatchAndClearEvents(entitiesWithEvents);
        
        // Assert
        await _mediator.Received(expectedCallCount).Publish(Arg.Any<DomainEventBase>());
    }
    
    [Fact]
    public async Task DispatchAndClearEvents_ShouldNot_DispatchEvents_WhenNoEvents()
    {
        // Arrange
        var entity = new TestEntity();
        const int expectedCallCount = 0;
        var entitiesWithEvents = new List<EntityBase<Guid>> { entity };
        
        var dispatcher = new MediatRDomainEventDispatcher(_mediator);
        
        // Act
        await dispatcher.DispatchAndClearEvents(entitiesWithEvents);
        
        // Assert
        await _mediator.Received(expectedCallCount).Publish(Arg.Any<DomainEventBase>());
    }
    
    [Fact]
    public async Task DispatchAndClearEvents_Should_ClearEvents()
    {
        // Arrange
        var entity = new TestEntity();
        entity.CallRegisterDomainEvents();
        entity.CallRegisterDomainEvents();
        const int expectedCount = 0;
        
        var dispatcher = new MediatRDomainEventDispatcher(_mediator);
        
        // Act
        await dispatcher.DispatchAndClearEvents(new List<EntityBase<Guid>> { entity });
        
        // Assert
        entity.DomainEvents.Should().HaveCount(expectedCount);
    }
}
