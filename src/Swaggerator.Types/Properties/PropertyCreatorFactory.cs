using System;
using System.Reflection;

using Swaggerator.Types.Enums;
using Swaggerator.Types.Extensions;
using Swaggerator.Types.Interfaces;

namespace Swaggerator.Types.Properties
{
    public static class PropertyCreatorFactory
    {
        /// <summary>
        ///     Create ISchemaCreator for Type
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>ISchemaCreator</returns>
        public static IPropertyCreator Create(Type type)
        {
            var dataType = type.GetDataType();

            switch (dataType)
            {
                case DataType.Boolean:
                    return new BooleanPropertyCreator();
                case DataType.Integer:
                    return new IntegerPropertyCreator();
                case DataType.Number:
                    return new NumberPropertyCreator();
                case DataType.String:
                    return new StringPropertyCreator();
                case DataType.Array:
                    return new StringPropertyCreator();
                case DataType.Object:
                    return new ReferencePropertyCreator();
            }

            return null;
        }

        public static ISchema CreateSchema(PropertyInfo propertyInfo)
        {
            var creator = Create(propertyInfo.PropertyType);

            return creator.Create(propertyInfo);
        }
    }
}