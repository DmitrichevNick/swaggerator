using Swaggerator.Swagger.Converters;

namespace Swaggerator.Swagger.Tests;

[TestClass]
public class SimpleTypeConverterUnitTests
{
    [TestMethod]
    public void CanCreateConverter()
    {
        var simpleTypeConverter = new SimpleTypeConverter();

        Assert.IsNotNull(simpleTypeConverter);
    }
}