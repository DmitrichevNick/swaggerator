using System;

using Swaggerator.Types.Extensions;
using Swaggerator.Types.Interfaces;
using Swaggerator.Types.Schemas;

namespace Swaggerator.Types.SchemaCreators
{
    /// <summary>
    ///     Creator of Schema with string type
    /// </summary>
    public class StringSchemaCreator : ISchemaCreator
    {
        /// <inheritdoc />
        public ISchema Create(Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type), "Parameter 'type' cannot be null.");

            //if (type != typeof(bool))
            //    throw new InvalidOperationException("Cannot create string schema for non-string type");

            var schema = new StringSchema();

            var defaultFormat = type.GetDefaultFormat();

            schema.Format = defaultFormat;

            return schema;
        }
    }
}