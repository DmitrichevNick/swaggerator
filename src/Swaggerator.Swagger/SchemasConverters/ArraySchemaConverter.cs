using System;

using Microsoft.OpenApi.Models;

using Swaggerator.Types.Interfaces;
using Swaggerator.Types.Schemas;

namespace Swaggerator.Swagger.SchemasConverters
{
    /// <summary>
    ///     SchemaConverter for <see cref="ArraySchema"/>
    /// </summary>
    public class ArraySchemaConverter : ISchemaConverter
    {
        /// <inheritdoc />
        public OpenApiSchema Convert(ISchema schema)
        {
            if (schema == null) throw new ArgumentNullException(nameof(schema));

            if (schema is ArraySchema arraySchema)
                return Convert(arraySchema);

            throw new ArgumentException($"Cannot convert schema of type {schema.GetType()}");
        }

        private OpenApiSchema Convert(ArraySchema arraySchema)
        {
            var itemsSchemaConverter = SchemaConverterFactory.Create(arraySchema.Items);

            var openApiSchema = new OpenApiSchema
            {
                Type = arraySchema.Type,
                UniqueItems = arraySchema.UniqueItems,
                Items = itemsSchemaConverter.Convert(arraySchema.Items)
            };

            return openApiSchema;
        }
    }
}