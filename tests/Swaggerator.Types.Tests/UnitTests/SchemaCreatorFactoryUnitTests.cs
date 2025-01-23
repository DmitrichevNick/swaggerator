using Swaggerator.Types.SchemaCreators;
using Swaggerator.Types.Tests.UnitTests.TestClasses;

namespace Swaggerator.Types.Tests;

[TestClass]
public class SchemaCreatorFactoryUnitTests
{
    [TestMethod]
    public void CanCreateReferenceSchemaCreator()
    {
        var objectType = new ObjectType();

        var objectCreator = SchemaCreatorFactory.Create(objectType.GetType());

        Assert.AreEqual(typeof(ReferenceSchemaCreator), objectCreator.GetType());
    }
}
