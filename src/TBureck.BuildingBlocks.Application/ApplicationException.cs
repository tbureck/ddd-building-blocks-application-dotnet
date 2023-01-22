using JetBrains.Annotations;

namespace TBureck.BuildingBlocks.Application;

/// <summary>
/// Wrapper for exceptions that occur in the domain layer. This makes it potentially easier to handle exceptions in the
/// upper layers.
/// </summary>
[PublicAPI]
public class ApplicationException : Exception
{
    
    public ApplicationException(string message, Exception cause) : base(message, cause) { }
}
