// ReSharper disable UnusedTypeParameter
// ReSharper disable UnusedType.Global

namespace Modulos.Messaging
{
    /// <summary>
    /// Defines CQRS query.
    /// </summary>
    /// <typeparam name="TResult">
    /// Result type.
    /// </typeparam>
    public interface IQuery<out TResult> : IQueryBase
    {    
    }
}