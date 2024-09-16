using FluentAssertions;

namespace FastProjects.SharedKernel.UnitTests.PagedListTests;

public class PagedList_HasPreviousPage
{
    [Fact]
    public void HasPreviousPage_Should_ReturnFalse_When_PageIsOne()
    {
        // Arrange
        var items = new List<int> { 1, 2, 3 };
        const int count = 3;
        const int page = 1;
        const int pageSize = 10;

        // Act
        var pagedList = new PagedList<int>(items, count, page, pageSize);

        // Assert
        pagedList.HasPreviousPage.Should().BeFalse();
    }

    [Fact]
    public void HasPreviousPage_Should_ReturnTrue_When_PageIsGreaterThanOne()
    {
        // Arrange
        var items = new List<int> { 1, 2, 3 };
        const int count = 10;
        const int page = 2;
        const int pageSize = 3;

        // Act
        var pagedList = new PagedList<int>(items, count, page, pageSize);

        // Assert
        pagedList.HasPreviousPage.Should().BeTrue();
    }
}
