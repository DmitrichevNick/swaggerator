using System;

using Microsoft.OpenApi.Models;

using Swaggerator.Types.Interfaces;
using Swaggerator.Types.Schemas;

namespace Swaggerator.Swagger.SchemasConverters
{
    /// <summary>
    ///     SchemaConverter for <see cref="NumberSchema"/>
    /// </summary>
    public class NumberSchemaConverter : ISchemaConverter
    {
        /// <inheritdoc />
        public OpenApiSchema Convert(ISchema schema)
        {
            if (schema == null) throw new ArgumentNullException(nameof(schema));

            if (schema is NumberSchema numberSchema)
                return Convert(numberSchema);

            throw new ArgumentException($"Cannot convert schema of type {schema.GetType()}");
        }

        private OpenApiSchema Convert(NumberSchema numberSchema)
        {
            var openApiSchema = new OpenApiSchema
            {
                Type = numberSchema.Type,
                Format = numberSchema.Format
            };

            return openApiSchema;
        }
    }
}