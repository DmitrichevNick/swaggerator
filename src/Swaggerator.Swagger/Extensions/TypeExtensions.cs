using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;
using Swaggerator.Swagger.Constants;

namespace Swaggerator.Swagger.Extensions
{
    /// <summary>
    ///     Extensions of Type
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        ///     Type is simple
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>Is Type simple?</returns>
        public static bool IsSimple(this Type type)
        {
            return Types.SimpleTypes.Contains(type);
        }

        /// <summary>
        ///     Get PropertyInfo list of properties of Type
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>List of PropertyInfo</returns>
        public static IList<PropertyInfo> GetPropertiesPropertyInfoList(this Type type)
        {
            return type.GetProperties().ToList();
        }

        /// <summary>
        ///     Get PropertyInfo list of public and not ignored properties of Type
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>List of PropertyInfo</returns>
        public static IList<PropertyInfo> GetPublicPropertiesInfoList(this Type type)
        {
            return type.GetProperties(BindingFlags.Public)
                .Where(propertyInfo => propertyInfo.GetCustomAttribute<JsonIgnoreAttribute>() == null)
                .ToList();
        }
    }
}