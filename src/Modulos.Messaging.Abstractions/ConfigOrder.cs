// ReSharper disable UnusedMember.Global

namespace Modulos.Messaging
{
    /// <summary>
    /// Defines  ordering for messaging configuration.
    /// </summary>
    public enum ConfigOrder
    {
        /// <summary>
        /// Reserved for internal modulos usage.
        /// </summary>
        Internal,

        /// <summary>
        /// Reserved for elements located in external libraries e.q., nuget packages.
        /// </summary>
        Library,

        /// <summary>
        /// Reserved for projects located in the same solution.
        /// </summary>
        Project,

        /// <summary>
        /// Reserved for elements located in application projects (e.q.: console app, web api).
        /// </summary>
        Application,

        /// <summary>
        /// Reserved for elements located in test projects.
        /// </summary>
        Test
    }
}