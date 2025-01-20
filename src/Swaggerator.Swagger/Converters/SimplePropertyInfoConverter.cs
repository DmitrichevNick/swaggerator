using System;
using System.Reflection;

using Microsoft.OpenApi.Models;

using Swaggerator.Swagger.Extensions;
using Swaggerator.Types.Extensions;

namespace Swaggerator.Swagger.Converters
{
    public class SimplePropertyInfoConverter : IPropertyInfoConverter
    {
        /// <inheritdoc/>
        public OpenApiSchema Convert(PropertyInfo propertyInfo)
        {
            var type = propertyInfo.PropertyType;

            if (!type.IsSimple())
                throw new InvalidOperationException("Cannot convert composite type as a simple one");

            var openApiSchema = new OpenApiSchema();

            openApiSchema.CopyFromSimplePropertyInfo(propertyInfo);

            return openApiSchema;
        }
    }
}