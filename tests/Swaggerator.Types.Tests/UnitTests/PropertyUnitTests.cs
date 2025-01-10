
using Swaggerator.Types.Primitives;

namespace Swaggerator.Types.Tests;

[TestClass]
public class PropertyUnitTests
{
    [TestMethod]
    public void CanCreateProperty()
    {
        var property = new Property();

        Assert.IsNotNull(property);
    }
}