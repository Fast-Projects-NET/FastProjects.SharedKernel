using FastProjects.ResultPattern;
using MediatR;

namespace FastProjects.SharedKernel;

/// <summary>
/// Marker interface for queries that return a result with a specific response type.
/// Inherits from IRequest with a Result of TResponse type.
/// </summary>
/// <typeparam name="TResponse">The type of the response.</typeparam>
public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
