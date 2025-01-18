using Swaggerator.Types.Interfaces;

namespace Swaggerator.Types.Primitives
{
    /// <summary>
    ///     Property type of OpenAPI
    /// </summary>
    public class Property : IRequireable
    {
        /// <summary>
        ///     Name of property
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Type of property value
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        ///     Example of property value
        /// </summary>
        public string Example { get; set; }

        /// <summary>
        ///     Format of property value
        /// </summary>
        public string Format { get; set; }

        /// <inheritdoc />
        public bool Required { get; set; }
    }
}