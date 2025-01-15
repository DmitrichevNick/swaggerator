
using Swaggerator.Types.Primitives;
using Swaggerator.Json.JsonNodes;

namespace Swaggerator.Json.Tests;

[TestClass]
public class SchemaNodeUnitTests
{
    [TestMethod]
    public void CanCreateSchemaNode()
    {
        var schema = new Schema("testSchemaName")
        {
            Properties = new List<Property>
            {
                new Property
                {
                    Name = "testPropertyName1",
                    Format = "testPropertyFormat1",
                    Example = "testPropertyExample1",
                    Type = "testPropertyType1"
                },
                new Property
                {
                    Name = "testPropertyName2",
                    Format = "testPropertyFormat2",
                    Example = "testPropertyExample2",
                    Type = "testPropertyType2"
                }
            }
        };

        var schemaNode = SchemaNode.Create(schema);

        Assert.IsNotNull(schemaNode);
    }
}