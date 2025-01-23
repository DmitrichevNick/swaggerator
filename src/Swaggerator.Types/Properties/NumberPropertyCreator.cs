using System.Reflection;

using Swaggerator.Types.Extensions;
using Swaggerator.Types.Interfaces;
using Swaggerator.Types.Schemas;

namespace Swaggerator.Types.Properties
{
    /// <summary>
    ///     Creator of number property of Object Schema
    /// </summary>
    public class NumberPropertyCreator : IPropertyCreator
    {
        /// <summary>
        ///     Create number Schema of Object property
        /// </summary>
        /// <param name="propertyInfo">Property</param>
        /// <returns>Schema</returns>
        public ISchema Create(PropertyInfo propertyInfo)
        {
            var schema = new NumberSchema();
            var defaultFormat = propertyInfo.PropertyType.GetDefaultFormat();

            schema.Format = defaultFormat;

            return schema;
        }
    }
}