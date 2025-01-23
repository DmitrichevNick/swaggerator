using System.Reflection;

using Swaggerator.Types.Interfaces;
using Swaggerator.Types.Schemas;

namespace Swaggerator.Types.Properties
{
    /// <summary>
    ///     Creator of boolean property of Object Schema
    /// </summary>
    public class BooleanPropertyCreator : IPropertyCreator
    {
        /// <summary>
        ///     Create boolean Schema of Object property
        /// </summary>
        /// <param name="propertyInfo">Property</param>
        /// <returns>Schema</returns>
        public ISchema Create(PropertyInfo propertyInfo)
            => new BooleanSchema();
    }
}