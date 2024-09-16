using FluentAssertions;

namespace FastProjects.SharedKernel.UnitTests.PagedListTests;

public class PagedList_ConstructorTests
{
    [Fact]
    public void Constructor_Should_SetProperties()
    {
        // Arrange
        var items = new List<int> { 1, 2, 3 };
        const int count = 3;
        const int page = 1;
        const int pageSize = 10;

        // Act
        var pagedList = new PagedList<int>(items, count, page, pageSize);

        // Assert
        pagedList.Items.Should().BeEquivalentTo(items);
        pagedList.TotalCount.Should().Be(count);
        pagedList.Page.Should().Be(page);
        pagedList.PageSize.Should().Be(pageSize);
        pagedList.TotalPages.Should().Be(1);
    }
    
    [Fact]
    public void Constructor_Should_SetTotalPages()
    {
        // Arrange
        var items = new List<int> { 1, 2, 3 };
        const int count = 10;
        const int page = 1;
        const int pageSize = 3;

        // Act
        var pagedList = new PagedList<int>(items, count, page, pageSize);

        // Assert
        pagedList.TotalPages.Should().Be(4);
    }
    
    [Fact]
    public void Constructor_Should_SetTotalPages_When_ItemsCountIsNotDivisibleByPageSize()
    {
        // Arrange
        var items = new List<int> { 1, 2, 3 };
        const int count = 10;
        const int page = 1;
        const int pageSize = 4;

        // Act
        var pagedList = new PagedList<int>(items, count, page, pageSize);

        // Assert
        pagedList.TotalPages.Should().Be(3);
    }
}
