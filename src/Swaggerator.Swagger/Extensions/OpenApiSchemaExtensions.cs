using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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
            openApiSchema.Title = propertyInfo.GetName();
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
            var type = propertyInfo.PropertyType;

            openApiSchema.Title = propertyInfo.GetName();

            var swaggerDataTypes = type.GetSwaggerDataTypeAndFormat();

            openApiSchema.Type = swaggerDataTypes.Item1.GetString();
            openApiSchema.Format = swaggerDataTypes.Item2;
        }
    }
}