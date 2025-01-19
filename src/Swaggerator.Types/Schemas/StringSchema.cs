using Swaggerator.Swagger.Extensions;

namespace Swaggerator.Types.Schemas
{
    /// <summary>
    ///     Swagger schema for String type
    /// </summary>
    public class StringSchema : PrimitiveSchema
    {
        public StringSchema()
        {
            Type = Enums.DataType.String.GetString();
        }

        /// <summary>
        ///     Swagger Format of primitive
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        ///     Swagger Pattern of string
        /// </summary>
        public string Pattern { get; set; }
    }
}