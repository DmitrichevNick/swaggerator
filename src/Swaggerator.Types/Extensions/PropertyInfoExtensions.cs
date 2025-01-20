using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Swaggerator.Types.Extensions
{
    /// <summary>
    ///     Extensions of PropertyInfo
    /// </summary>
    public static class PropertyInfoExtensions
    {
        /// <summary>
        ///     Is property required?
        /// </summary>
        /// <param name="propertyInfo">PropertyInfo</param>
        /// <returns>Is marked as required?</returns>
        public static bool IsRequired(this PropertyInfo propertyInfo)
        {
            return propertyInfo.GetCustomAttribute<RequiredAttributeAttribute>() != null
            || propertyInfo.GetCustomAttribute<JsonRequiredAttribute>() != null;
        }

        /// <summary>
        ///     Is property ignored?
        /// </summary>
        /// <param name="propertyInfo">PropertyInfo</param>
        /// <returns>Is marked as ignored?</returns>
        public static bool IsIgnored(this PropertyInfo propertyInfo)
        {
            return propertyInfo.GetCustomAttribute<JsonIgnoreAttribute>() != null
            || propertyInfo.GetCustomAttribute<IgnoreDataMemberAttribute>() != null;
        }

        /// <summary>
        ///     Get name of property
        /// </summary>
        /// <param name="propertyInfo">PropertyInfo</param>
        /// <returns>Name</returns>
        public static string GetName(this PropertyInfo propertyInfo)
        {
            var jsonPropertyNameAttribute = propertyInfo.GetCustomAttribute<JsonPropertyNameAttribute>();

            if (jsonPropertyNameAttribute != null)
                return jsonPropertyNameAttribute.Name;

            return propertyInfo.Name;
        }
    }
}