using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using Microsoft.OpenApi.Models;
using Swaggerator.Swagger.Constants;
using Swaggerator.Swagger.Enums;
using Swaggerator.Swagger.Extensions;

namespace Swaggerator.Swagger.Converters
{
    public class ArrayPropertyInfoConverter : IPropertyInfoConverter
    {
        /// <inheritdoc/>
        public OpenApiSchema Convert(PropertyInfo propertyInfo)
        {
            var type = propertyInfo.PropertyType;

            if (!(type is IEnumerable))
                throw new InvalidOperationException("Cannot convert not enumerable type as an array one.");

            var genericTypeDefinition = type.GetGenericTypeDefinition();
            var arrayElementType = genericTypeDefinition.GenericTypeArguments[0];

            var openApiSchema = new OpenApiSchema();

            openApiSchema.Type = SwaggerDataTypes.Array.GetString();
            openApiSchema.CopyFromPropertyInfo(propertyInfo);

            return openApiSchema;
        }
    }
}