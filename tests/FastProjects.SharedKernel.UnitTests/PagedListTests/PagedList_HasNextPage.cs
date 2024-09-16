using FluentAssertions;

namespace FastProjects.SharedKernel.UnitTests.PagedListTests;

public class PagedList_HasNextPage
{
    [Fact]
    public void HasNextPage_Should_ReturnFalse_When_PageIsEqualToTotalPages()
    {
        // Arrange
        var items = new List<int> { 1, 2, 3 };
        const int count = 3;
        const int page = 1;
        const int pageSize = 10;

        // Act
        var pagedList = new PagedList<int>(items, count, page, pageSize);

        // Assert
        pagedList.HasNextPage.Should().BeFalse();
    }

    [Fact]
    public void HasNextPage_Should_ReturnTrue_When_PageIsLessThanTotalPages()
    {
        // Arrange
        var items = new List<int> { 1, 2, 3 };
        const int count = 10;
        const int page = 1;
        const int pageSize = 3;

        // Act
        var pagedList = new PagedList<int>(items, count, page, pageSize);

        // Assert
        pagedList.HasNextPage.Should().BeTrue();
    }
}
