using System;
using System.Reflection;

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
                    return new BooleanSchemaCreator();
                case DataType.Integer:
                    return new IntegerSchemaCreator();
                case DataType.Number:
                    return new NumberSchemaCreator();
                case DataType.String:
                    return new StringSchemaCreator();
                case DataType.Array:
                    return new ArraySchemaCreator();
                case DataType.Object:
                    return new ObjectSchemaCreator();
            }

            return null;
        }

        public static ISchema CreateSchema(Type type)
        {
            var creator = Create(type);

            return creator.Create(type);
        }

        public static ISchema CreateSchema(PropertyInfo propertyInfo)
        {
            var creator = Create(propertyInfo.PropertyType);

            return creator.Create(propertyInfo);
        }
    }
}