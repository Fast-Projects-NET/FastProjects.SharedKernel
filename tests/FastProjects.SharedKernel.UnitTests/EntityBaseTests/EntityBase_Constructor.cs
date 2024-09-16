using FluentAssertions;

namespace FastProjects.SharedKernel.UnitTests.EntityBaseTests;

public class EntityBase_Constructor
{
    private class TestEntity : EntityBase
    {
        public TestEntity(Guid id)
        {
            Id = id;
        }
        
        public TestEntity()
        {
        }
    }
    
    [Fact]
    public void Constructor_Should_SetNewGuidAsDefaultId()
    {
        // Arrange
        // Act
        var entity = new TestEntity();
        
        // Assert
        entity.Id.Should().NotBe(Guid.Empty);
    }
    
    [Fact]
    public void Constructor_Should_SetSpecifiedId()
    {
        // Arrange
        var id = Guid.NewGuid();
        
        // Act
        var entity = new TestEntity(id);
        
        // Assert
        entity.Id.Should().Be(id);
    }
}
