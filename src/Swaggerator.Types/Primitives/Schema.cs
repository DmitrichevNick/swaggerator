using System.Collections.Generic;

namespace Swaggerator.Types.Primitives
{
    /// <summary>
    ///     Schema type of OpenAPI
    /// </summary>
    public class Schema
    {
        /// <summary>
        ///     Constructor
        /// </summary>
        public Schema()
        {
            Properties = new List<Property>();
        }
        /// <summary>
        ///     Collection of properties of Schema
        /// </summary>
        public IList<Property> Properties;

        /// <summary>
        ///     Name of schema
        /// </summary>
        public string Name { get; set; }
    }
}