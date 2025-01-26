using Swaggerator.Types.SchemaCreators;
using Swaggerator.Types.Schemas;
using Swaggerator.Types.Tests.UnitTests.TestClasses;

namespace Swaggerator.Types.Tests;

[TestClass]
public class ObjectSchemaCreatorUnitTests
{
    [TestMethod]
    public void Constructor_Parameterless_InstanceNotNull()
    {
        var creator = new ObjectSchemaCreator();

        Assert.IsNotNull(creator);
    }

    [TestMethod]
    public void Create_AnyClass_HasObjectType()
    {
        const string _objectType = "object";
        var creator = new ObjectSchemaCreator();

        var result = (ObjectSchema)creator.Create(typeof(EmptyClass));

        Assert.AreEqual(_objectType, result.Type);
    }

    [TestMethod]
    public void Create_EmptyClass_HasNoRequired()
    {
        const int _zeroCount = 0;
        var creator = new ObjectSchemaCreator();

        var result = (ObjectSchema)creator.Create(typeof(EmptyClass));

        Assert.AreEqual(_zeroCount, result.Required.Count);
    }

    [TestMethod]
    public void Create_EmptyClass_HasNoProperties()
    {
        const int _zeroCount = 0;
        var creator = new ObjectSchemaCreator();

        var result = (ObjectSchema)creator.Create(typeof(EmptyClass));

        Assert.AreEqual(_zeroCount, result.Properties.Count);
    }

    [TestMethod]
    public void Create_ClassWithPropeties_HasPropeties()
    {
        const int _zeroCount = 0;
        var creator = new ObjectSchemaCreator();

        var result = (ObjectSchema)creator.Create(typeof(ClassWithProperties));

        Assert.AreNotEqual(_zeroCount, result.Properties.Count);
    }

    [TestMethod]
    public void Create_ClassWithRequiredPrimitiveProperties_HasRequired()
    {
        const int _zeroCount = 0;
        var creator = new ObjectSchemaCreator();

        var result = (ObjectSchema)creator.Create(typeof(ClassWithRequiredPrimitiveProperties));

        Assert.AreNotEqual(_zeroCount, result.Required.Count);
    }

    [TestMethod]
    public void Create_ClassWithJsonRequiredPrimitiveProperties_HasRequired()
    {
        const int _zeroCount = 0;
        var creator = new ObjectSchemaCreator();

        var result = (ObjectSchema)creator.Create(typeof(ClassWithJsonRequiredPrimitiveProperties));

        Assert.AreNotEqual(_zeroCount, result.Required.Count);
    }

    [TestMethod]
    public void Create_ClassWithStringProperty_HasStringSchemaProperty()
    {
        const int _zeroCount = 0;
        var creator = new ObjectSchemaCreator();

        var result = (ObjectSchema)creator.Create(typeof(ClassWithProperties));
        var schemasCount = result.Properties.Count(property => property.Value is StringSchema);

        Assert.AreNotEqual(_zeroCount, schemasCount);
    }

    [TestMethod]
    public void Create_ClassWithIntegerProperty_HasIntegerSchemaProperty()
    {
        const int _zeroCount = 0;
        var creator = new ObjectSchemaCreator();

        var result = (ObjectSchema)creator.Create(typeof(ClassWithProperties));
        var schemasCount = result.Properties.Count(property => property.Value is IntegerSchema);

        Assert.AreNotEqual(_zeroCount, schemasCount);
    }

    [TestMethod]
    public void Create_ClassWithDateTimeProperty_HasStringSchemaProperty()
    {
        const int _zeroCount = 0;
        var creator = new ObjectSchemaCreator();

        var result = (ObjectSchema)creator.Create(typeof(ClassWithProperties));
        var schemasCount = result.Properties.Count(property => property.Value is StringSchema);

        Assert.AreNotEqual(_zeroCount, schemasCount);
    }

    [TestMethod]
    public void Create_ClassWithFloatProperty_HasNumberSchemaProperty()
    {
        const int _zeroCount = 0;
        var creator = new ObjectSchemaCreator();

        var result = (ObjectSchema)creator.Create(typeof(ClassWithProperties));
        var schemasCount = result.Properties.Count(property => property.Value is NumberSchema);

        Assert.AreNotEqual(_zeroCount, schemasCount);
    }

    [TestMethod]
    public void Create_ClassWithObjectProperty_HasReferenceSchemaProperty()
    {
        const int _zeroCount = 0;
        var creator = new ObjectSchemaCreator();

        var result = (ObjectSchema)creator.Create(typeof(ClassWithProperties));
        var schemasCount = result.Properties.Count(property => property.Value is ReferenceSchema);

        Assert.AreNotEqual(_zeroCount, schemasCount);
    }

    [TestMethod]
    public void Create_ClassWithArrayProperty_HasArraySchemaProperty()
    {
        const int _zeroCount = 0;
        var creator = new ObjectSchemaCreator();

        var result = (ObjectSchema)creator.Create(typeof(ClassWithArrayProperty<int>));
        var schemasCount = result.Properties.Count(property => property.Value is ArraySchema);

        Assert.AreNotEqual(_zeroCount, schemasCount);
    }
}