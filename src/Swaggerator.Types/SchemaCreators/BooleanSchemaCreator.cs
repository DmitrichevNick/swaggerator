using System;

using Swaggerator.Types.Interfaces;
using Swaggerator.Types.Schemas;

namespace Swaggerator.Types.SchemaCreators
{
    /// <summary>
    ///     Creator of Schema with boolean type
    /// </summary>
    public class BooleanSchemaCreator : ISchemaCreator
    {
        /// <inheritdoc />
        public ISchema Create(Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type), "Parameter 'type' cannot be null.");

            if (type != typeof(bool))
                throw new InvalidOperationException("Cannot create boolean schema for non-boolean type");

            return new BooleanSchema();
        }
    }
}