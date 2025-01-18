using System;
using System.Linq;
using System.Reflection;
using Microsoft.OpenApi.Models;
using Swaggerator.Swagger.Constants;
using Swaggerator.Swagger.Extensions;

namespace Swaggerator.Swagger.Converters
{
    public class SimplePropertyInfoConverter : IPropertyInfoConverter
    {
        /// <inheritdoc/>
        public OpenApiSchema Convert(PropertyInfo propertyInfo)
        {
            var type = propertyInfo.PropertyType;

            if (!Types.SimpleTypes.Contains(type))
                throw new InvalidOperationException("Cannot convert composite type as a simple one");

            var openApiSchema = new OpenApiSchema();

            openApiSchema.CopyFromSimplePropertyInfo(propertyInfo);

            return openApiSchema;
        }
    }
}