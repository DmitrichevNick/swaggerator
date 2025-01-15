
using Swaggerator.Types.Primitives;
using Swaggerator.Json.JsonNodes;

namespace Swaggerator.Json.Tests;

[TestClass]
public class PropertyNodeUnitTests
{
    [TestMethod]
    public void CanCreatePropertyNode()
    {
        var property = new Property
        {
            Name = "testPropertyName",
            Format = "testPropertyFormat",
            Example = "testPropertyExample",
            Type = "testPropertyType"
        };

        var propertyNode = PropertyNode.Create(property);

        Assert.IsNotNull(propertyNode);
    }
}