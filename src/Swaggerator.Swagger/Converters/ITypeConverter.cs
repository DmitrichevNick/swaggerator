using System;

using Microsoft.OpenApi.Models;

namespace Swaggerator.Swagger.Converters
{
    /// <summary>
    ///     Interface of Type converter
    /// </summary>
    public interface ITypeConverter
    {
        /// <summary>
        ///     Convert Type to OpenApiSchema
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>OpenApiSchema</returns>
        OpenApiSchema Convert(Type type);
    }
}