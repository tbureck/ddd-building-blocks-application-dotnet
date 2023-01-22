using MediatR;

namespace TBureck.BuildingBlocks.Application.Processing;

/// <summary>
/// Describes the data of a query that will solely read data from the system. 
/// </summary>
/// <typeparam name="TResult">The type to be returned by this query</typeparam>
public interface IQuery<out TResult> : IRequest<TResult> { }
