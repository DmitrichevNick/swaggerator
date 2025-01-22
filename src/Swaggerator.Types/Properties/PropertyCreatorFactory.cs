using System;
using System.Reflection;

using Swaggerator.Types.Enums;
using Swaggerator.Types.Extensions;
using Swaggerator.Types.Schemas;

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
                    return new StringPropertyCreator();
                case DataType.Integer:
                    return new StringPropertyCreator();
                case DataType.Number:
                    return new StringPropertyCreator();
                case DataType.String:
                    return new StringPropertyCreator();
                case DataType.Array:
                    return new StringPropertyCreator();
                case DataType.Object:
                    return new StringPropertyCreator();
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