
using Swaggerator.Types.Primitives;
using Swaggerator.Json.JsonNodes;

namespace Swaggerator.Json.Tests;

[TestClass]
public class PropertyJsonNodeUnitTests
{
    [TestMethod]
    public void CanCreatePropertyJsonNode()
    {
        var property = new Property
        {
            Name = "testPropertyName",
            Format = "testPropertyFormat",
            Example = "testPropertyExample",
            Type = "testPropertyType"
        };

        var propertyJsonNode = PropertyJsonNode.Create(property);

        Assert.IsNotNull(propertyJsonNode);
    }
}