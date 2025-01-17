using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Microsoft.OpenApi.Models;

namespace Swaggerator.Swagger.Extensions
{
    /// <summary>
    ///     Extensions of OpenApiSchema
    /// </summary>
    public static class OpenApiSchemaExtensions
    {
        /// <summary>
        ///     Copy properties from PropertyInfo to OpenApiSchema
        /// </summary>
        /// <param name="openApiSchema">OpenApiSchema to fill</param>
        /// <param name="propertyInfo">PropertyInfo from fill</param>
        public static void CopyFromPropertyInfo(this OpenApiSchema openApiSchema, PropertyInfo propertyInfo)
        {
            openApiSchema.CopyFromSimplePropertyInfo(propertyInfo);
            openApiSchema.Required = new HashSet<string>(propertyInfo.GetType()
                .GetPublicPropertiesInfoList()
                .Where(internalPropertyInfo => propertyInfo.IsRequired())
                .Select(internalPropertyInfo => propertyInfo.GetName())
                .ToList());
        }

        /// <summary>
        ///     Copy properties from PropertyInfo to OpenApiSchema
        /// </summary>
        /// <param name="openApiSchema">OpenApiSchema to fill</param>
        /// <param name="propertyInfo">PropertyInfo from fill</param>
        public static void CopyFromSimplePropertyInfo(this OpenApiSchema openApiSchema, PropertyInfo propertyInfo)
        {
            openApiSchema.Title = propertyInfo.GetName();
        }
    }
}