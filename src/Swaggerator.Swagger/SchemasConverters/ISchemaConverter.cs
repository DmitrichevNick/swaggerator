using Microsoft.OpenApi.Models;

using Swaggerator.Types.Schemas;

namespace Swaggerator.Swagger.SchemasConverters
{
    /// <summary>
    ///     Interface of Schema converter
    /// </summary>
    public interface ISchemaConverter
    {
        /// <summary>
        ///     Convert Schema to OpenApiSchema
        /// </summary>
        /// <param name="schema">Schema</param>
        /// <returns>OpenApiSchema</returns>
        OpenApiSchema Convert(Schema schema);
    }
}