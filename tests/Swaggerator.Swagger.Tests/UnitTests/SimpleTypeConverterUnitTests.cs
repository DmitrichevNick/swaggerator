using System.Globalization;

using Microsoft.OpenApi.Writers;

using Swaggerator.Swagger.Converters;
using Swaggerator.Swagger.Tests.UnitTests.TestClasses;

namespace Swaggerator.Swagger.Tests;

[TestClass]
public class SimpleTypeConverterUnitTests
{
    [TestMethod]
    public void CanCreateWithoutParameters()
    {
        var simpleTypeConverter = new SimplePropertyInfoConverter();

        Assert.IsNotNull(simpleTypeConverter);
    }

    [TestMethod]
    public void CanConvertStringProperty()
    {
        var type = typeof(TestClassWithStringPropertyWithoutJson)
            .GetProperty(nameof(TestClassWithStringPropertyWithoutJson.StringProperty));
        var converter = new SimplePropertyInfoConverter();

        var openApiSchema = converter.Convert(type);

        using var textWriter = new StringWriter(CultureInfo.InvariantCulture);
        {
            var jsonWriter = new OpenApiJsonWriter(textWriter);

            openApiSchema.SerializeAsV3(jsonWriter);

            var result = textWriter.ToString();

            Assert.AreEqual(result, "{\n  \"title\": \"StringProperty\",\n  \"type\": \"string\"\n}");
        }
    }


}