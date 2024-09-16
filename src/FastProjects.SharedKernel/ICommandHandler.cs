using FastProjects.ResultPattern;
using MediatR;

namespace FastProjects.SharedKernel;

/// <summary>
/// Interface for handling commands that return a result.
/// Inherits from IRequestHandler with a command type and a Result type.
/// </summary>
/// <typeparam name="TCommand">The type of the command.</typeparam>
public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand, Result>
    where TCommand : ICommand
{
}

/// <summary>
/// Interface for handling commands that return a result with a specific response type.
/// Inherits from IRequestHandler with a command type and a Result of TResponse type.
/// </summary>
/// <typeparam name="TCommand">The type of the command.</typeparam>
/// <typeparam name="TResponse">The type of the response.</typeparam>
public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, Result<TResponse>>
    where TCommand : ICommand<TResponse>
{
}
