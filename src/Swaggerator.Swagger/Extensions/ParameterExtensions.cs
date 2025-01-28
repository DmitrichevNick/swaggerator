using System;

using Microsoft.OpenApi.Models;

using Swaggerator.Types.Parameters;

namespace Swaggerator.Swagger.Extensions
{
    /// <summary>
    ///     Extensions of Parameter
    /// </summary>
    public static class ParameterExtensions
    {
        /// <summary>
        ///     Convert <see cref="Parameter" /> to <see cref="OpenApiParameter" />
        /// </summary>
        /// <param name="parameter">Parameter</param>
        /// <returns>OpenApiParameter</returns>
        public static OpenApiParameter GetOpenApiParameter(this Parameter parameter)
        {
            if (parameter == null)
                throw new ArgumentNullException(nameof(parameter), "Parameter value cannot be null.");

            if (parameter is PathParameter pathParameter)
                return GetOpenApiParameter(pathParameter);

            throw new InvalidOperationException($"Unpredicted type of parameter '{parameter.GetType()}'.");
        }

        private static OpenApiParameter GetOpenApiParameter(PathParameter parameter)
        {
            return new OpenApiParameter
            {
                In = ParameterLocation.Path,
                Description = parameter.Description,
                Required = true,
                Name = parameter.Name
            };
        }

        private static OpenApiParameter GetOpenApiParameter(QueryParameter parameter)
        {
            return new OpenApiParameter
            {
                In = ParameterLocation.Path,
                Description = parameter.Description,
                Required = parameter.Required,
                Name = parameter.Name
            };
        }

        private static OpenApiParameter GetOpenApiParameter(HeaderParameter parameter)
        {
            return new OpenApiParameter
            {
                In = ParameterLocation.Path,
                Description = parameter.Description,
                Required = parameter.Required,
                Name = parameter.Name
            };
        }

        private static OpenApiParameter GetOpenApiParameter(CookieParameter parameter)
        {
            return new OpenApiParameter
            {
                In = ParameterLocation.Cookie,
                Description = parameter.Description,
                Required = parameter.Required,
                Name = parameter.Name
            };
        }
    }
}