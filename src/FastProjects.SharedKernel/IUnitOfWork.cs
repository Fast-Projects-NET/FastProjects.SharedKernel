namespace FastProjects.SharedKernel;

/// <summary>
/// Represents a unit of work that encapsulates a series of operations to be committed as a single transaction.
/// </summary>
public interface IUnitOfWork
{
    /// <summary>
    /// Asynchronously saves all changes made in the unit of work.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous save operation. The task result contains the number of state entries written to the database.</returns>
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
