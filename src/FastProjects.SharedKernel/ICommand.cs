using FastProjects.ResultPattern;
using MediatR;

namespace FastProjects.SharedKernel;

/// <summary>
/// Marker interface for commands that return a result.
/// Inherits from IRequest with a Result type.
/// </summary>
public interface ICommand : IRequest<Result>
{
}

/// <summary>
/// Marker interface for commands that return a result with a specific response type.
/// Inherits from IRequest with a Result of TResponse type.
/// </summary>
/// <typeparam name="TResponse">The type of the response.</typeparam>
public interface ICommand<TResponse> : IRequest<Result<TResponse>>
{
}
