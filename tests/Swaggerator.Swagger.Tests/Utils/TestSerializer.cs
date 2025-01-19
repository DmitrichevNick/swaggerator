using System.Globalization;

using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Writers;

namespace Swaggerator.Swagger.Tests.Utils
{
    public static class TestSerializer
    {
        public static string SerializeAsV3(OpenApiSchema openApiSchema)
        {
            using var textWriter = new StringWriter(CultureInfo.InvariantCulture);
            {
                var jsonWriter = new OpenApiJsonWriter(textWriter);

                openApiSchema.SerializeAsV3(jsonWriter);

                return textWriter.ToString();
            }
        }
    }
}