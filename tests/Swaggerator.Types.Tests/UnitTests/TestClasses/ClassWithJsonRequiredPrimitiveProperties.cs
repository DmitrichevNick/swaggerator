using System.Text.Json.Serialization;

namespace Swaggerator.Types.Tests.UnitTests.TestClasses
{
    /// <summary>
    ///     Class with JSON required primitive properties
    /// </summary>
    internal class ClassWithJsonRequiredPrimitiveProperties
    {
        [JsonRequired]
        public string? StringPropety { get; set; }
        public int IntProperty { get; set; }

        public DateTime DateTimeProperty { get; set; }
    }
}