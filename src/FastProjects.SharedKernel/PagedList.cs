namespace FastProjects.SharedKernel;

/// <summary>
/// Represents a paginated list of items.
/// </summary>
/// <typeparam name="T">The type of items in the list.</typeparam>
public class PagedList<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PagedList{T}"/> class.
    /// </summary>
    /// <param name="items">The list of items.</param>
    /// <param name="count">The total count of items.</param>
    /// <param name="page">The current page number.</param>
    /// <param name="pageSize">The size of the page.</param>
    public PagedList(List<T> items, int count, int page, int pageSize)
    {
        Page = page;
        PageSize = pageSize;
        TotalCount = count;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        Items = items;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="PagedList{T}"/> class.
    /// </summary>
    private PagedList() { }

    /// <summary>
    /// Gets the list of items.
    /// </summary>
    public List<T> Items { get; private init; } = null!;

    /// <summary>
    /// Gets the current page number.
    /// </summary>
    public int Page { get; private init; }

    /// <summary>
    /// Gets the size of the page.
    /// </summary>
    public int PageSize { get; private init; }

    /// <summary>
    /// Gets the total number of pages.
    /// </summary>
    public int TotalPages { get; private init; }

    /// <summary>
    /// Gets the total count of items.
    /// </summary>
    public int TotalCount { get; private init; }

    /// <summary>
    /// Gets a value indicating whether there is a previous page.
    /// </summary>
    public bool HasPreviousPage => Page > 1;

    /// <summary>
    /// Gets a value indicating whether there is a next page.
    /// </summary>
    public bool HasNextPage => Page < TotalPages;

    /// <summary>
    /// Gets an empty <see cref="PagedList{T}"/>.
    /// </summary>
    public static PagedList<T> Empty => new()
    {
        Page = 0,
        PageSize = 0,
        TotalCount = 0,
        TotalPages = 0,
        Items = []
    };
}
