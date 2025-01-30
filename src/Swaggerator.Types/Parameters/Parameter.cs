using Swaggerator.Types.Interfaces;

namespace Swaggerator.Types.Parameters
{
    /// <summary>
    ///     Parameter of endpoint
    /// </summary>
    public abstract class Parameter
    {
        /// <summary>
        ///     Description of parameter
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     Name of parameter
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Schema of parameter
        /// </summary>
        public ISchema Schema { get; set; }
    }
}