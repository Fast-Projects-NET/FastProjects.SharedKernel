using FluentAssertions;

namespace FastProjects.SharedKernel.UnitTests.EntityBaseTests;

public class EntityBaseGeneric_Constructor
{
    private class TestEntity : EntityBase<Guid>
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
    public void Constructor_Should_SetDefaultId()
    {
        // Arrange
        var defaultId = default(Guid);
        
        // Act
        var entity = new TestEntity();
        
        // Assert
        entity.Id.Should().Be(defaultId);
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
