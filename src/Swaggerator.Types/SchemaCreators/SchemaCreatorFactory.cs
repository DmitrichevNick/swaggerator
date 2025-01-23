using System;

using Swaggerator.Types.Enums;
using Swaggerator.Types.Extensions;
using Swaggerator.Types.Interfaces;

namespace Swaggerator.Types.SchemaCreators
{
    public static class SchemaCreatorFactory
    {
        /// <summary>
        ///     Create ISchemaCreator for Type
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>ISchemaCreator</returns>
        public static ISchemaCreator Create(Type type)
        {
            var dataType = type.GetDataType();

            switch (dataType)
            {
                case DataType.Boolean:
                    return new ObjectSchemaCreator();
                case DataType.Integer:
                    return new ObjectSchemaCreator();
                case DataType.Number:
                    return new ObjectSchemaCreator();
                case DataType.String:
                    return new ObjectSchemaCreator();
                case DataType.Array:
                    return new ObjectSchemaCreator();
                case DataType.Object:
                    return new ReferenceSchemaCreator();
            }

            return null;
        }

        public static ISchema CreateSchema(Type type)
        {
            var creator = Create(type);

            return creator.Create(type);
        }
    }
}