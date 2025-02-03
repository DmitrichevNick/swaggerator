using System;

using Microsoft.OpenApi.Models;

using Swaggerator.Types.Interfaces;
using Swaggerator.Types.Schemas;

namespace Swaggerator.Swagger.SchemasConverters
{
    /// <summary>
    ///     SchemaConverter for <see cref="BooleanSchema"/>
    /// </summary>
    public class BooleanSchemaConverter : ISchemaConverter
    {
        /// <inheritdoc />
        public OpenApiSchema Convert(ISchema schema)
        {
            if (schema == null) throw new ArgumentNullException(nameof(schema));

            if (schema is BooleanSchema booleanSchema)
                return Convert(booleanSchema);

            throw new ArgumentException($"Cannot convert schema of type {schema.GetType()}");
        }

        private OpenApiSchema Convert(BooleanSchema booleanSchema)
        {
            var openApiSchema = new OpenApiSchema
            {
                Type = booleanSchema.Type
            };

            return openApiSchema;
        }
    }
}