
using Swaggerator.Types.Primitives;

namespace Swaggerator.Types.Tests;

[TestClass]
public class ComponentUnitTests
{
    [TestMethod]
    public void CanCreateComponent()
    {
        var component = new Component();

        Assert.IsNotNull(component);
    }

    [TestMethod]
    public void NewComponentHasNotNullSchemaList()
    {
        var component = new Component();

        Assert.IsNotNull(component.Schemas);
    }

    [TestMethod]
    public void NewComponentHasEmptySchemaList()
    {
        var component = new Component();

        Assert.AreEqual(component.Schemas.Count, 0);
    }
}