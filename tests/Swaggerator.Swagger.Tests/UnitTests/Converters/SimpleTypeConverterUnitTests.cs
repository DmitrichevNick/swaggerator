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
}