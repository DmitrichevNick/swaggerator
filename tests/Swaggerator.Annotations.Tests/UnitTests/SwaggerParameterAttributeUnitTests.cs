namespace Swaggerator.Annotations.Tests;

[TestClass]
public class SwaggerParameterAttributeUnitTests
{
    [TestMethod]
    public void CanCreateSwaggerParameterAttribute()
    {
        var swaggerParameterAttribute = new SwaggerParameterAttribute();

        Assert.IsNotNull(swaggerParameterAttribute);
    }

    [TestMethod]
    public void CanCreateSwaggerParameterAttributeWithDescription()
    {
        var swaggerParameterAttribute = new SwaggerParameterAttribute("description");

        Assert.IsNotNull(swaggerParameterAttribute);
    }

    [TestMethod]
    public void NewSwaggerParameterAttributeDescriptionIsEmpty()
    {
        var swaggerParameterAttribute = new SwaggerParameterAttribute();

        Assert.IsTrue(string.IsNullOrEmpty(swaggerParameterAttribute.Description));
    }

    [TestMethod]
    public void NewSwaggerParameterAttributeDescriptionIsNotEmpty()
    {
        var swaggerParameterAttribute = new SwaggerParameterAttribute("description");

        Assert.IsFalse(string.IsNullOrEmpty(swaggerParameterAttribute.Description));
    }

    [TestMethod]
    public void CanSetDescriptionWithConstructor()
    {
        var swaggerParameterAttribute = new SwaggerParameterAttribute("description");

        Assert.AreEqual(swaggerParameterAttribute.Description, "description");
    }
}