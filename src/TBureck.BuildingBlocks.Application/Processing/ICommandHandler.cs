using JetBrains.Annotations;
using MediatR;

namespace TBureck.BuildingBlocks.Application.Processing;

/// <summary>
/// Handles a command of the specified type without returning data. Commands will usually make calls on the domain layer
/// of your application. They capsule potential exceptions that occur in the domain into a ApplicationException that can
/// more easily be handled by the calling code, e.g. your API or web application.
/// </summary>
/// <typeparam name="TCommand">The command type to be executed</typeparam>
[PublicAPI]
public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand> where TCommand : ICommand { }

/// <summary>
/// Handles a command of the specified type, returning data of the specified type. Commands will usually make calls on
/// the domain layer of your application. They capsule potential exceptions that occur in the domain into a
/// ApplicationException that can more easily be handled by the calling code, e.g. your API or web application.
/// </summary>
/// <typeparam name="TCommand">The command type to be executed</typeparam>
/// <typeparam name="TResult">The result type to be returned</typeparam>
[PublicAPI]
public interface ICommandHandler<in TCommand, TResult> : IRequestHandler<TCommand, TResult> where TCommand : ICommand<TResult> { }
