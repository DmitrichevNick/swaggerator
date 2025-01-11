
using Swaggerator.Types.Primitives;
using Swaggerator.Yaml.YamlNodes;

namespace Swaggerator.Yaml.Tests;

[TestClass]
public class PropertyYamlNodeUnitTests
{
    [TestMethod]
    public void CanCreatePropertyYamlNode()
    {
        var property = new Property
        {
            Name = "testPropertyName",
            Format = "testPropertyFormat",
            Example = "testPropertyExample",
            Type = "testPropertyType"
        };

        var propertyYamlNode = PropertyYamlNode.Create(property);

        Assert.IsNotNull(propertyYamlNode);
    }
}