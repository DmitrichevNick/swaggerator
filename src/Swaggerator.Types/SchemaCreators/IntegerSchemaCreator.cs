using System;

using Swaggerator.Types.Extensions;
using Swaggerator.Types.Interfaces;
using Swaggerator.Types.Schemas;

namespace Swaggerator.Types.SchemaCreators
{
    /// <summary>
    ///     Creator of Schema with integer type
    /// </summary>
    public class IntegerSchemaCreator : ISchemaCreator
    {
        /// <inheritdoc />
        public ISchema Create(Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type), "Parameter 'type' cannot be null.");

            //if (type != typeof(bool))
            //    throw new InvalidOperationException("Cannot create integer schema for non-integer type");

            var schema = new IntegerSchema();

            var defaultFormat = type.GetDefaultFormat();

            schema.Format = defaultFormat;

            return schema;
        }
    }
}