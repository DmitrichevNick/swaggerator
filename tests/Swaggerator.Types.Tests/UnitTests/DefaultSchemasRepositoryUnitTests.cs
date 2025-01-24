using Swaggerator.Types.Schemas;

namespace Swaggerator.Types.Tests;

[TestClass]
public class DefaultSchemasRepositoryUnitTests
{
    [TestMethod]
    public void Constructor_Parameterless_InstanceNotNull()
    {
        var defaultSchemasRepository = new DefaultSchemasRepository();

        Assert.IsNotNull(defaultSchemasRepository);
    }

    [TestMethod]
    public void GetSchemas_Empty_HasNoItems()
    {
        var defaultSchemasRepository = new DefaultSchemasRepository();

        var count = defaultSchemasRepository.GetSchemas().Count();

        Assert.AreEqual(0, count);
    }

    [TestMethod]
    public void GetSchemas_NotEmpty_HasItems()
    {
        var defaultSchemasRepository = new DefaultSchemasRepository();

        defaultSchemasRepository.TryAdd("testSchemaId", null);
        var count = defaultSchemasRepository.GetSchemas().Count();

        Assert.AreNotEqual(0, count);
    }

    [TestMethod]
    public void TryAddSchema_NotEmpty_HasItems()
    {
        var defaultSchemasRepository = new DefaultSchemasRepository();

        defaultSchemasRepository.TryAdd("testSchemaId", null);
        var count = defaultSchemasRepository.GetSchemas().Count();

        Assert.AreNotEqual(0, count);
    }

    [TestMethod]
    public void TryGetSchema_NewSchema_HasSameReference()
    {
        const string schemaId = "testSchemaId";
        var defaultSchemasRepository = new DefaultSchemasRepository();
        var sourceSchema = new ObjectSchema();

        defaultSchemasRepository.TryAdd(schemaId, sourceSchema);
        var targetSchema = defaultSchemasRepository.GetSchema(schemaId);

        Assert.AreSame(sourceSchema, targetSchema);
    }
}