using System;
using System.Reflection;

using Microsoft.OpenApi.Models;

using Swaggerator.Swagger.Extensions;

namespace Swaggerator.Swagger.Converters
{
    public class ObjectPropertyInfoConverter : IPropertyInfoConverter
    {
        /// <inheritdoc/>
        public OpenApiSchema Convert(PropertyInfo propertyInfo)
        {
            var type = propertyInfo.PropertyType;

            if (type.IsSimple())
                throw new InvalidOperationException("Cannot convert simple type as a reference one");

            var openApiSchema = new OpenApiSchema();

            openApiSchema.CopyFromPropertyInfo(propertyInfo);

            return openApiSchema;
        }
    }
}