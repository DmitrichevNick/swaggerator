using Swaggerator.Types.Interfaces;

namespace Swaggerator.Types.Parameters
{
    /// <summary>
    ///     Query parameter of endpoint
    /// </summary>
    public class QueryParameter : Parameter, IRequired
    {
        /// <inheritdoc />
        public bool Required { get; set; }
    }
}