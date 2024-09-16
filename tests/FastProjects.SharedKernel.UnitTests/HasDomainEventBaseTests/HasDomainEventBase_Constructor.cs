using FluentAssertions;

namespace FastProjects.SharedKernel.UnitTests.HasDomainEventBaseTests;

public class HasDomainEventBase_Constructor
{
    private class TestHasDomainEventsBase : HasDomainEventsBase
    {
    }
    
    [Fact]
    public void Constructor_Should_CreateEmptyDomainEventsList()
    {
        // Arrange
        // Act
        var hasDomainEventsBase = new TestHasDomainEventsBase();
        
        // Assert
        hasDomainEventsBase.DomainEvents.Should().BeEmpty();
    }
    
    [Fact]
    public void Constructor_Should_CreateNewDomainEventsListForEachInstance()
    {
        // Arrange
        // Act
        var hasDomainEventsBase1 = new TestHasDomainEventsBase();
        var hasDomainEventsBase2 = new TestHasDomainEventsBase();
        
        // Assert
        hasDomainEventsBase1.DomainEvents.Should().NotBeSameAs(hasDomainEventsBase2.DomainEvents);
    }
}
