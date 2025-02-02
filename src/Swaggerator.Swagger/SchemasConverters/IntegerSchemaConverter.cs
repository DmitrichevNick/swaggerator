using System;

using Microsoft.OpenApi.Models;

using Swaggerator.Types.Schemas;

namespace Swaggerator.Swagger.SchemasConverters
{
    /// <summary>
    ///     SchemaConverter for <see cref="IntegerSchema"/>
    /// </summary>
    public class IntegerSchemaConverter : ISchemaConverter
    {
        /// <inheritdoc />
        public OpenApiSchema Convert(Schema schema)
        {
            if (schema == null) throw new ArgumentNullException(nameof(schema));

            if (schema is IntegerSchema integerSchema)
                return Convert(integerSchema);

            throw new ArgumentException($"Cannot convert schema of type {schema.GetType()}");
        }

        private OpenApiSchema Convert(IntegerSchema integerSchema)
        {
            var openApiSchema = new OpenApiSchema
            {
                Type = integerSchema.Type,
                Format = integerSchema.Format
            };

            return openApiSchema;
        }
    }
}