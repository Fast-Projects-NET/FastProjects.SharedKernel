using FluentAssertions;

namespace FastProjects.SharedKernel.UnitTests.DomainEventBaseTests;

public class DomainEventBase_Constructor
{
    private class TestDomainEvent() : DomainEventBase
    {
    }
    
    [Fact]
    public void Constructor_Should_SetUtcNowAsDefaultDateOccurred()
    {
        // Arrange
        DateTime beforeCreation = DateTime.UtcNow;
        var precision = TimeSpan.FromMilliseconds(1);
        
        // Act
        var domainEvent = new TestDomainEvent();
        
        // Assert
        domainEvent.DateOccurred.Should().BeCloseTo(beforeCreation, precision);
    }
    
    [Fact]
    public void Constructor_Should_SetDateOccurredToSpecifiedValue()
    {
        // Arrange
        DateTime dateOccurred = DateTime.UtcNow.AddDays(-1);
        
        // Act
        var domainEvent = new TestDomainEvent { DateOccurred = dateOccurred };
        
        // Assert
        domainEvent.DateOccurred.Should().Be(dateOccurred);
    }
}
