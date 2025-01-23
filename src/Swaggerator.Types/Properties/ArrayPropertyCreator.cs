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
            var innerType = propertyInfo.PropertyType.GetGenericArguments().First();

            var innerSchema = SchemaCreatorFactory.CreateSchema(innerType);

            schema.Items = innerSchema;

            return schema;
        }
    }
}