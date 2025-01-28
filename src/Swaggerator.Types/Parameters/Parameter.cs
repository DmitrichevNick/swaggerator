using Swaggerator.Types.Interfaces;

namespace Swaggerator.Types.Parameters
{
    /// <summary>
    ///     Abstract parameter of endpoint
    /// </summary>
    public abstract class Parameter : IDescribed, INamed
    {
        /// <inheritdoc />
        public string Description { get; set; }

        /// <inheritdoc />
        public string Name { get; set; }
    }
}