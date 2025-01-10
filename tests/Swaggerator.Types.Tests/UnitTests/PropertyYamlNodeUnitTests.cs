
using Swaggerator.Types.Primitives;
using Swaggerator.Types.YamlNodes;

namespace Swaggerator.Types.Tests;

[TestClass]
public class PropertyYamlNodeUnitTests
{
    [TestMethod]
    public void CanCreatePropertyYamlNode()
    {
        var property = new Property();

        property.Name = "testPropertyName";
        property.Format = "testPropertyFormat";
        property.Example = "testPropertyExample";
        property.Type = "testPropertyType";

        var propertyYamlNode = PropertyYamlNode.Create(property);
        //YamlDotNet.RepresentationModel.YamlScalarNode
        var str = propertyYamlNode.ToString();
        Console.WriteLine(str);
        Assert.IsNotNull(propertyYamlNode);
    }
}