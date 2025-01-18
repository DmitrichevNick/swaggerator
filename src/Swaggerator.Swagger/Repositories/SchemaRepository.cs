using System;
using System.Collections.Generic;
using Microsoft.OpenApi.Models;

namespace Swaggerator.Swagger.Repositories
{
    /// <summary>
    ///     Repository of OpenApiSchemas
    /// </summary>
    public class SchemaRepository
    {
        private readonly Dictionary<string, OpenApiSchema> _schemas;

        public SchemaRepository()
        {
            _schemas = new Dictionary<string, OpenApiSchema>();
        }

        private string GetSchemaId(OpenApiSchema openApiSchema)
        {
            return openApiSchema.Title;
        }

        public bool IsSchemaProcessed(string schemaId)
        {
            return _schemas.ContainsKey(schemaId);
        }

        public bool AddSchema(OpenApiSchema openApiSchema)
        {
            if (_schemas.ContainsKey(openApiSchema.Title))
                throw new InvalidOperationException("Cannot add processed schema.");

            _schemas.Add(openApiSchema.Title, openApiSchema);

            return true;
        }
    }
}