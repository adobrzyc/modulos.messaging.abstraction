using System.Collections.Generic;
using System.Threading.Tasks;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global

namespace Modulos.Messaging
{
    /// <summary>
    /// Defines configuration source for specified <see cref="Transport"/>.
    /// </summary>
    public interface IEndpointConfigSource
    {
        /// <summary>
        /// Specifies the transport identifier of configuration for which it is designed.
        /// </summary>
        TransportEngineId Transport { get; }

        /// <summary>
        /// Returns configuration based on specified parameters.
        /// </summary>
        /// <returns>
        /// Collection of the configurations.
        /// </returns>
        Task<IEnumerable<IEndpointConfig>> GetConfiguration(EndpointConfigMark endpointConfigMark);
    }
}