using Swaggerator.Types.Interfaces;

namespace Swaggerator.Types.Parameters
{
    /// <summary>
    ///     Cookie parameter of endpoint
    /// </summary>
    public class CookieParameter : Parameter, IRequired
    {
        /// <inheritdoc />
        public bool Required { get; set; }
    }
}