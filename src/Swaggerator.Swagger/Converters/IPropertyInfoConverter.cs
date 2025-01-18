using System.Reflection;

using Microsoft.OpenApi.Models;

namespace Swaggerator.Swagger.Converters
{
    /// <summary>
    ///     Interface of PropertyInfo converter
    /// </summary>
    public interface IPropertyInfoConverter
    {
        /// <summary>
        ///     Convert PropertyInfo to OpenApiSchema
        /// </summary>
        /// <param name="propertyInfo">PropertyInfo</param>
        /// <returns>OpenApiSchema</returns>
        OpenApiSchema Convert(PropertyInfo propertyInfo);
    }
}