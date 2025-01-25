using System.ComponentModel.DataAnnotations;

namespace Swaggerator.Types.Tests.UnitTests.TestClasses
{
    /// <summary>
    ///     Class with required primitive properties
    /// </summary>
    internal class ClassWithRequiredPrimitiveProperties
    {
        [Required]
        public string? StringPropety { get; set; }
        public int IntProperty { get; set; }

        public DateTime DateTimeProperty { get; set; }
    }
}