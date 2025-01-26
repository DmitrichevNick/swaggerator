using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Swaggerator.Types.Interfaces;
using Swaggerator.Types.SchemaCreators;
using Swaggerator.Types.Schemas;

namespace Swaggerator.Types.Properties
{
    /// <summary>
    ///     Creator of array property of Object Schema
    /// </summary>
    public class ArrayPropertyCreator : IPropertyCreator
    {
        /// <summary>
        ///     Create array Schema of Object property
        /// </summary>
        /// <param name="propertyInfo">Property</param>
        /// <returns>Schema</returns>
        public ISchema Create(PropertyInfo propertyInfo)
        {
            var schema = new ArraySchema();

            var innerType = GetBaseTypeOfEnumerable(propertyInfo.PropertyType);
            var innerSchema = SchemaCreatorFactory.CreateSchema(innerType);

            schema.Items = innerSchema;

            return schema;
        }

        private Type GetBaseTypeOfEnumerable(Type type)
        {
            var genericEnumerableInterface = type
                .GetInterfaces()
                .FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEnumerable<>));

            if (genericEnumerableInterface == null)
            {
                //If we're in this block, the type implements IEnumerable, but not IEnumerable<T>;
                //you'll have to decide what to do here.

                //Justin Harvey's (now deleted) answer suggested enumerating the 
                //enumerable and examining the type of its elements; this 
                //is a good idea, but keep in mind that you might have a
                //mixed collection.
            }

            var elementType = genericEnumerableInterface.GetGenericArguments()[0];
            return elementType.IsGenericType && elementType.GetGenericTypeDefinition() == typeof(Nullable<>)
                ? elementType.GetGenericArguments()[0]
                : elementType;
        }
    }
}