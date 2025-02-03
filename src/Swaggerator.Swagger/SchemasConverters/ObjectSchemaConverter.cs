using System;
using System.Linq;

using Microsoft.OpenApi.Models;

using Swaggerator.Types.Interfaces;
using Swaggerator.Types.Schemas;

namespace Swaggerator.Swagger.SchemasConverters
{
    /// <summary>
    ///     SchemaConverter for <see cref="ObjectSchema"/>
    /// </summary>
    public class ObjectSchemaConverter : ISchemaConverter
    {
        /// <inheritdoc />
        public OpenApiSchema Convert(ISchema schema)
        {
            if (schema == null) throw new ArgumentNullException(nameof(schema));

            if (schema is ObjectSchema objectSchema)
                return Convert(objectSchema);

            throw new ArgumentException($"Cannot convert schema of type {schema.GetType()}");
        }

        private OpenApiSchema Convert(ObjectSchema objectSchema)
        {
            var openApiSchema = new OpenApiSchema
            {
                Type = objectSchema.Type,
                Required = objectSchema.Required,
                Properties = objectSchema.Properties
                    .ToDictionary(
                        property => property.Key,
                        property => SchemaConverterFactory.Create(property.Value).Convert(property.Value))
            };

            return openApiSchema;
        }
    }
}