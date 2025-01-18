using System.Collections.Generic;

using Swaggerator.Types.Interfaces;

namespace Swaggerator.Types.Primitives
{
    /// <summary>
    ///     Schema type of OpenAPI
    /// </summary>
    public class Schema : ITyped
    {
        /// <summary>
        ///     Constructor with Schema name
        /// </summary>
        /// <param name="name">Schema name</param>
        public Schema(string name)
        {
            Name = name;
            Type = Enums.Type.Object;
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

        /// <inheritdoc />
        public string Type { get; set; }
    }
}