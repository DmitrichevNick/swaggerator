using System.Reflection;

using Swaggerator.Types.Extensions;
using Swaggerator.Types.Interfaces;
using Swaggerator.Types.Schemas;

namespace Swaggerator.Types.Properties
{
    /// <summary>
    ///     Creator of String property of Object Schema
    /// </summary>
    public class StringPropertyCreator : IPropertyCreator
    {
        /// <summary>
        ///     Create String Schema of Object property
        /// </summary>
        /// <param name="propertyInfo">Property</param>
        /// <returns>Schema</returns>
        public ISchema Create(PropertyInfo propertyInfo)
        {
            var schema = new StringSchema();
            var defaultFormat = propertyInfo.PropertyType.GetDefaultFormat();

            schema.Format = defaultFormat;

            return schema;
        }
    }
}