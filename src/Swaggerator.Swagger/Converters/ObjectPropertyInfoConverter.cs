using System;
using System.Linq;
using System.Reflection;
using Microsoft.OpenApi.Models;
using Swaggerator.Swagger.Constants;
using Swaggerator.Swagger.Extensions;

namespace Swaggerator.Swagger.Converters
{
    public class ObjectPropertyInfoConverter : IPropertyInfoConverter
    {
        /// <inheritdoc/>
        public OpenApiSchema Convert(PropertyInfo propertyInfo)
        {
            var type = propertyInfo.PropertyType;

            if (Types.SimpleTypes.Contains(type))
                throw new InvalidOperationException("Cannot convert simple type as a reference one");

            var openApiSchema = new OpenApiSchema();

            openApiSchema.CopyFromPropertyInfo(propertyInfo);

            return openApiSchema;
        }
    }
}