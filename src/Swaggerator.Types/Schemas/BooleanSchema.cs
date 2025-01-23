using Swaggerator.Swagger.Extensions;
using Swaggerator.Types.Enums;

namespace Swaggerator.Types.Schemas
{
    /// <summary>
    ///     Schema of boolean of Swagger
    /// </summary>
    public class BooleanSchema : PrimitiveSchema
    {
        /// <summary>
        ///     Parameterless constructor
        /// </summary>
        public BooleanSchema()
        {
            Type = DataType.Boolean.GetString();
        }
    }
}