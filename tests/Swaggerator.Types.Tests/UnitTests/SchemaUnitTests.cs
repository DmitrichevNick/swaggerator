
using Swaggerator.Types.Primitives;

namespace Swaggerator.Types.Tests;

[TestClass]
public class SchemaUnitTests
{
    [TestMethod]
    public void CanCreateSchema()
    {
        var schema = new Schema();

        Assert.IsNotNull(schema);
    }
}