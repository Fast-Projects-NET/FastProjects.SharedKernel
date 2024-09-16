using FastProjects.ResultPattern;
using MediatR;

namespace FastProjects.SharedKernel;

/// <summary>
/// Interface for handling queries that return a result with a specific response type.
/// Inherits from IRequestHandler with a query type and a Result of TResponse type.
/// </summary>
/// <typeparam name="TQuery">The type of the query.</typeparam>
/// <typeparam name="TResponse">The type of the response.</typeparam>
public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}
