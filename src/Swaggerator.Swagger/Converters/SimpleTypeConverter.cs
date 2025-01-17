using System;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Swaggerator.Swagger.Constants;
using Swaggerator.Swagger.Extensions;

namespace Swaggerator.Swagger.Converters
{
    public class SimpleTypeConverter
    {
        public OpenApiSchema Convert(PropertyInfo propertyInfo)
        {
            var type = propertyInfo.PropertyType;

            if (!Types.SimpleTypes.Contains(type))
                throw new InvalidOperationException("Cannot convert composite type as a simple one");

            var openApiSchema = OpenApiTypeMapper.MapTypeToOpenApiPrimitiveType(type);

            openApiSchema.CopyFromSimplePropertyInfo(propertyInfo);

            return openApiSchema;
        }
    }
}