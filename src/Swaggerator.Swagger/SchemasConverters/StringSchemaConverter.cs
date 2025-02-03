using System;

using Microsoft.OpenApi.Models;

using Swaggerator.Types.Interfaces;
using Swaggerator.Types.Schemas;

namespace Swaggerator.Swagger.SchemasConverters
{
    /// <summary>
    ///     SchemaConverter for <see cref="StringSchema"/>
    /// </summary>
    public class StringSchemaConverter : ISchemaConverter
    {
        /// <inheritdoc />
        public OpenApiSchema Convert(ISchema schema)
        {
            if (schema == null) throw new ArgumentNullException(nameof(schema));

            if (schema is StringSchema stringSchema)
                return Convert(stringSchema);

            throw new ArgumentException($"Cannot convert schema of type {schema.GetType()}");
        }

        private OpenApiSchema Convert(StringSchema stringSchema)
        {
            var openApiSchema = new OpenApiSchema
            {
                Type = stringSchema.Type,
                Format = stringSchema.Format,
                Pattern = stringSchema.Pattern
            };

            return openApiSchema;
        }
    }
}