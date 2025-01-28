using Swaggerator.Types.Interfaces;

namespace Swaggerator.Types.Parameters
{
    /// <summary>
    ///     Header parameter of endpoint
    /// </summary>
    public class HeaderParameter : Parameter, IRequired
    {
        /// <inheritdoc />
        public bool Required { get; set; }
    }
}