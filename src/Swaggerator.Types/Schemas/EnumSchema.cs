using System.Collections.Generic;

using Swaggerator.Swagger.Extensions;

namespace Swaggerator.Types.Schemas
{
    public class EnumSchema : Schema
    {
        /// <summary>
        ///     Parameterless constructor
        /// </summary>
        public EnumSchema()
        {
            Type = Enums.DataType.String.GetString();
            Enum = new HashSet<string>();
        }

        /// <summary>
        ///     Values of enum Schema
        /// </summary>
        public ISet<string> Enum { get; set; }
    }
}