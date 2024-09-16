using FluentAssertions;

namespace FastProjects.SharedKernel.UnitTests.HasDomainEventBaseTests;

public class HasDomainEventsBase_ClearDomainEvents
{
    private class TestDomainEvent : DomainEventBase
    {
    }
    
    private class TestHasDomainEventsBase : HasDomainEventsBase
    {
        public void CallRegisterDomainEvents() => RegisterDomainEvent(new TestDomainEvent());
    }
    
    [Fact]
    public void ClearDomainEvents_Should_RemoveAllDomainEvents()
    {
        // Arrange
        var hasDomainEventsBase = new TestHasDomainEventsBase();
        hasDomainEventsBase.CallRegisterDomainEvents();
        hasDomainEventsBase.CallRegisterDomainEvents();
        const int expectedCount = 0;
        
        // Act
        hasDomainEventsBase.ClearDomainEvents();
        
        // Assert
        hasDomainEventsBase.DomainEvents.Should().HaveCount(expectedCount);
    }
}
