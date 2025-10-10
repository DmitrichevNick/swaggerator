namespace Swaggerator.Configurer.Tests;

[TestClass]
public class ConfigLoaderUnitTests
{
    [TestMethod]
    public void LoadConfigByPath()
    {
        var path = "/home/foxocat/repos/swaggerator/config.json";

        var config = ConfigLoader.LoadConfigByPath(path);

        Assert.IsNotNull(config);
    }
}