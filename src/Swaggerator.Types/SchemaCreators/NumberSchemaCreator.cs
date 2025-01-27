using System;
using System.Reflection;

using Swaggerator.Types.Extensions;
using Swaggerator.Types.Interfaces;
using Swaggerator.Types.Schemas;

namespace Swaggerator.Types.SchemaCreators
{
    /// <summary>
    ///     Creator of Schema with number type
    /// </summary>
    public class NumberSchemaCreator : ISchemaCreator
    {
        /// <inheritdoc />
        public ISchema Create(Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type), "Parameter 'type' cannot be null.");

            //if (type != typeof(bool))
            //    throw new InvalidOperationException("Cannot create number schema for non-number type");

            var schema = new NumberSchema();

            var defaultFormat = type.GetDefaultFormat();

            schema.Format = defaultFormat;

            return schema;
        }

        /// <inheritdoc />
        public ISchema Create(PropertyInfo propertyInfo)
        {
            if (propertyInfo == null)
                throw new ArgumentNullException(nameof(propertyInfo), "Parameter 'propertyInfo' cannot be null.");

            var schema = Create(propertyInfo.PropertyType);

            return schema;
        }
    }
}