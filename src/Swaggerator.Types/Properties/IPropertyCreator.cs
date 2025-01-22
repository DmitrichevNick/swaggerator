using System.Reflection;

using Swaggerator.Types.Schemas;

namespace Swaggerator.Types.Properties
{
    /// <summary>
    ///     Creator of property of Object Schema
    /// </summary>
    public interface IPropertyCreator
    {
        /// <summary>
        ///     Create Schema of Object property
        /// </summary>
        /// <param name="propertyInfo">Property</param>
        /// <returns>Schema</returns>
        ISchema Create(PropertyInfo propertyInfo);
    }
}