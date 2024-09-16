using FluentAssertions;

namespace FastProjects.SharedKernel.UnitTests.PagedListTests;

public class PagedList_Empty
{
    [Fact]
    public void Empty_Should_ReturnEmptyPagedList()
    {
        // Arrange
        // Act
        PagedList<int> pagedList = PagedList<int>.Empty;

        // Assert
        pagedList.Items.Should().BeEmpty();
        pagedList.TotalCount.Should().Be(0);
        pagedList.Page.Should().Be(0);
        pagedList.PageSize.Should().Be(0);
        pagedList.TotalPages.Should().Be(0);
    }
}
