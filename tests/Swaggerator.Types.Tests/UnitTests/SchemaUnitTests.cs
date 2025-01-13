
using Swaggerator.Types.Primitives;

namespace Swaggerator.Types.Tests;

[TestClass]
public class SchemaUnitTests
{
    [TestMethod]
    public void CanCreateSchema()
    {
        var schema = new Schema("TestSchema");

        Assert.IsNotNull(schema);
    }

    [TestMethod]
    public void CanCreateSchemaWithName()
    {
        var schema = new Schema("TestSchema");

        Assert.AreEqual(schema.Name, "TestSchema");
    }

    [TestMethod]
    public void SchemaDefaultTypeIsObject()
    {
        var schema = new Schema("TestSchema");

        Assert.AreEqual(schema.Type, "object");
    }

    [TestMethod]
    public void SchemaDefaultPropertiesNotNull()
    {
        var schema = new Schema("TestSchema");

        Assert.IsNotNull(schema.Properties);
    }

    [TestMethod]
    public void SchemaDefaultPropertiesIsEmpty()
    {
        var schema = new Schema("TestSchema");

        Assert.AreEqual(schema.Properties.Count, 0);
    }

    [TestMethod]
    public void CanAddPropertyToSchema()
    {
        var schema = new Schema("TestSchema");

        schema.Properties.Add(new Property
        {
            Name = "TestPropertyName"
        });

        Assert.AreEqual(schema.Properties.Count, 1);
    }
}