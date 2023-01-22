using JetBrains.Annotations;
using MediatR;

namespace TBureck.BuildingBlocks.Application.Processing;

/// <summary>
/// Describes the data of a command that will change the system's state. This command will not return anything.
/// </summary>
[PublicAPI]
public interface ICommand : IRequest { }

/// <summary>
/// Describes the data of a command that will change the system's state. This command will return a result, e.g. an
/// object that has been created during the command.
/// </summary>
/// <typeparam name="TResult">The type of the result to be returned by this command</typeparam>
[PublicAPI]
public interface ICommand<out TResult> : IRequest<TResult> { }
