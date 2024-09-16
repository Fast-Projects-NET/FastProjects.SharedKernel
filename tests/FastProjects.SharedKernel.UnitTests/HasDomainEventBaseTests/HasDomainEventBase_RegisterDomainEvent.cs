using FluentAssertions;

namespace FastProjects.SharedKernel.UnitTests.HasDomainEventBaseTests;

public class HasDomainEventBase_RegisterDomainEvent
{
    private class TestDomainEvent : DomainEventBase
    {
    }
    
    private class TestHasDomainEventsBase : HasDomainEventsBase
    {
        public void CallRegisterDomainEvents() => RegisterDomainEvent(new TestDomainEvent());
    }
    
    [Fact]
    public void RegisterDomainEvent_Should_AddDomainEventToList()
    {
        // Arrange
        var hasDomainEventsBase = new TestHasDomainEventsBase();
        const int expectedCount = 1;
        
        // Act
        hasDomainEventsBase.CallRegisterDomainEvents();
        
        // Assert
        hasDomainEventsBase.DomainEvents.Should().HaveCount(expectedCount);
    }
    
    [Fact]
    public void RegisterDomainEvent_Should_AddMultipleDomainEventsToList()
    {
        // Arrange
        var hasDomainEventsBase = new TestHasDomainEventsBase();
        const int expectedCount = 2;
        
        // Act
        hasDomainEventsBase.CallRegisterDomainEvents();
        hasDomainEventsBase.CallRegisterDomainEvents();
        
        // Assert
        hasDomainEventsBase.DomainEvents.Should().HaveCount(expectedCount);
    }
}
