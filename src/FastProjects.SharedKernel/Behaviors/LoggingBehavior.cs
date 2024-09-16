using System.Diagnostics;
using FastProjects.ResultPattern;
using Microsoft.Extensions.Logging;
using Serilog.Context;
using MediatR;
using Newtonsoft.Json;

namespace FastProjects.SharedKernel.Behaviors;

/// <summary>
/// Logging behavior for MediatR pipeline.
/// Logs the execution details of a request, including success, failure, and exceptions.
/// </summary>
/// <typeparam name="TRequest">The type of the request.</typeparam>
/// <typeparam name="TResponse">The type of the response.</typeparam>
public sealed class LoggingBehavior<TRequest, TResponse>(
    ILogger<LoggingBehavior<TRequest, TResponse>> logger)
    : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IBaseRequest
    where TResponse : Result
{
    /// <summary>
    /// Handles the request and logs the execution details.
    /// </summary>
    /// <param name="request">The request object.</param>
    /// <param name="next">The next delegate in the pipeline.</param>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>The response from the next delegate in the pipeline.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the request is null.</exception>
    /// <exception cref="Exception">Thrown when an exception occurs during request processing.</exception>
    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request, nameof(request));
        
        string requestName = request.GetType().Name;

        logger.LogInformation("Executing request {RequestName}", requestName);
        
        var sw = Stopwatch.StartNew();
        
        try
        {
            TResponse result = await next();
            sw.Stop();

            if (result.IsSuccess)
            {
                logger.LogInformation(
                    "Request {RequestName} processed successfully in {ElapsedMs} ms at {EndTime}", 
                    requestName, sw.ElapsedMilliseconds, DateTimeOffset.Now);
            }
            else
            {
                using (LogContext.PushProperty("Errors", JsonConvert.SerializeObject(result.Errors), true))
                {
                    logger.LogError(
                        "Request {RequestName} processed with error in {ElapsedMs} ms at {EndTime}", 
                        requestName, sw.ElapsedMilliseconds, DateTimeOffset.Now);
                }
            }

            return result;
        }
        catch (Exception exception)
        {
            sw.Stop();

            logger.LogError(
                exception, 
                "Request {RequestName} processing failed in {ElapsedMs} ms at {EndTime}", 
                requestName, sw.ElapsedMilliseconds, DateTimeOffset.Now);

            throw;
        }
    }
}
