using System;
using System.Collections.Generic;

using Swaggerator.Types.Interfaces;

namespace Swaggerator.Types.Schemas
{
    /// <summary>
    ///     Default Schemas repository
    /// </summary>
    public class DefaultSchemasRepository : ISchemasRepository
    {
        private readonly IDictionary<string, ISchema> _schemas;

        /// <summary>
        ///     Parameterless constructor
        /// </summary>
        public DefaultSchemasRepository()
        {
            _schemas = new Dictionary<string, ISchema>();
        }

        /// <inheritdoc />
        public ISchema GetSchema(string schemaId)
        {
            if (!_schemas.ContainsKey(schemaId))
                throw new ArgumentOutOfRangeException(
                    nameof(schemaId),
                     $"There is no schema in repository with id {schemaId}");

            return _schemas[schemaId];
        }

        /// <inheritdoc />
        public IEnumerable<ISchema> GetSchemas()
        {
            return _schemas.Values;
        }

        /// <inheritdoc />
        public bool TryAdd(string schemaId, ISchema schema)
        {
            if (_schemas.ContainsKey(schemaId)) return false;

            _schemas.Add(schemaId, schema);

            return true;
        }

        /// <inheritdoc />
        public bool TryGetSchema(string schemaId, out ISchema schema)
        {
            schema = null;

            if (!_schemas.ContainsKey(schemaId)) return false;

            schema = _schemas[schemaId];

            return true;
        }
    }
}