using System;
using System.Collections;
using System.Reflection;

using Microsoft.OpenApi.Models;

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

            var openApiSchema = new OpenApiSchema();
            var genericTypeDefinition = type.GetGenericTypeDefinition();
            var arrayElementType = genericTypeDefinition.GenericTypeArguments[0];

            openApiSchema.Type = Types.Enums.DataType.Array.GetString();
            openApiSchema.CopyFromPropertyInfo(propertyInfo);

            if (arrayElementType.IsSimple())
            {
                //openApiSchema.Items =
                var swaggerDataTypes = arrayElementType.GetSwaggerDataTypeAndFormat();

                openApiSchema.Type = swaggerDataTypes.Item1.GetString();
                openApiSchema.Format = swaggerDataTypes.Item2;
            }
            else if (arrayElementType.IsEnumerable())
            {
                openApiSchema.Type = Types.Enums.DataType.Array.GetString();
            }
            else
            {
                openApiSchema.Type = Types.Enums.DataType.Object.GetString();

            }





            return openApiSchema;
        }
    }
}