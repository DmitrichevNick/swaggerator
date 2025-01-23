using Swaggerator.Swagger.SchemasConverters;
using Swaggerator.Swagger.Tests.Utils;
using Swaggerator.Types.Schemas;

namespace Swaggerator.Swagger.Tests;

[TestClass]
public class StringSchemaConverterUnitTests
{
    [TestMethod]
    public void CanCreateWithoutParameters()
    {
        var stringSchemaConverter = new StringSchemaConverter();

        Assert.IsNotNull(stringSchemaConverter);
    }

    [TestMethod]
    public void CanConvertStringProperty()
    {
        var stringSchema = new StringSchema
        {
            Format = "testformat",
            Pattern = "\\d+"
        };
        var stringSchemaConverter = new StringSchemaConverter();

        var openApiSchema = stringSchemaConverter.Convert(stringSchema);
        var stringOpenApiSchema = TestSerializer.SerializeAsV3(openApiSchema);

        Assert.AreEqual(stringOpenApiSchema, "{\n  \"pattern\": \"\\\\d+\",\n  \"type\": \"string\",\n  \"format\": \"testformat\"\n}");
    }
}