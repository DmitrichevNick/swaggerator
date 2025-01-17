using System.Globalization;
using Microsoft.OpenApi.Writers;
using Swaggerator.Swagger.Converters;

namespace Swaggerator.Swagger.Tests;

[TestClass]
public class SimpleTypeConverterUnitTests
{
    [TestMethod]
    public void CanCreateWithoutParameters()
    {
        var simpleTypeConverter = new SimpleTypeConverter();

        Assert.IsNotNull(simpleTypeConverter);
    }

    [TestMethod]
    public void CanConvertStringProperty()
    {
        var type = typeof(TestClass).GetProperty(nameof(TestClass.TestStringProperty));
        var converter = new SimpleTypeConverter();

        var openApiSchema = converter.Convert(type);

        using var textWriter = new StringWriter(CultureInfo.InvariantCulture);
        {
            var jsonWriter = new OpenApiJsonWriter(textWriter);

            openApiSchema.SerializeAsV3(jsonWriter);

            var result = textWriter.ToString();

            Assert.AreEqual(result, "{\n  \"title\": \"TestStringProperty\",\n  \"type\": \"string\"\n}");
        }
    }

    private class TestClass
    {
        public string TestStringProperty { get; set; }
    }
}
