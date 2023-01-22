using MediatR;

namespace TBureck.BuildingBlocks.Application.Processing;

/// <summary>
/// Handles a query of the specified type, returning data of the specified type. Commands will usually make calls on
/// the domain layer of your application. They capsule potential exceptions that occur in the domain into an
/// ApplicationException that can more easily be handled by the calling code, e.g. your API or web application.
/// </summary>
/// <typeparam name="TQuery"></typeparam>
/// <typeparam name="TResult"></typeparam>
public interface IQueryHandler<in TQuery, TResult> : IRequestHandler<TQuery, TResult> where TQuery : IQuery<TResult> { }
