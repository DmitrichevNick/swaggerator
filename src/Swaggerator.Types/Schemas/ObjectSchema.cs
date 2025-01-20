using System.Collections.Generic;

using Swaggerator.Swagger.Extensions;

namespace Swaggerator.Types.Schemas
{
    /// <summary>
    ///     Object types of Schema
    /// </summary>
    public class ObjectSchema : Schema
    {
        /// <summary>
        ///     Parameterless constructor
        /// </summary>
        public ObjectSchema()
        {
            Type = Enums.DataType.Object.GetString();
            Required = new HashSet<string>();
            Properties = new Dictionary<string, Schema>();
        }

        /// <summary>
        ///     Unique set of required properties
        /// </summary>
        public ISet<string> Required { get; set; }

        public Dictionary<string, Schema> Properties { get; set; }
    }
}