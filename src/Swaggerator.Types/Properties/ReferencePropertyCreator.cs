using System.Reflection;

using Swaggerator.Types.Schemas;

namespace Swaggerator.Types.Properties
{
    /// <summary>
    ///     Creator of Reference property of Object Schema
    /// </summary>
    public class ReferencePropertyCreator : IPropertyCreator
    {
        /// <summary>
        ///     Create Reference Schema of Object property
        /// </summary>
        /// <param name="propertyInfo">Property</param>
        /// <returns>Schema</returns>
        public ISchema Create(PropertyInfo propertyInfo)
        {
            var schemaId = propertyInfo.PropertyType.Name;

            var schema = new ReferenceSchema($"#/components/schemas/{schemaId}");

            return schema;
        }
    }
}